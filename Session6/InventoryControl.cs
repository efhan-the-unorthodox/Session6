using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session6
{
    public partial class InventoryControl : Form
    {
        public InventoryControl()
        {
            InitializeComponent();
        }

        private void InventoryControl_Load(object sender, EventArgs e)
        {
            loadEMOrders();
            loadWarehouses();
            loadAllocationMethods();
        }
        private void loadEMOrders()
        {
            using (Session6Entities db = new Session6Entities())
            {
                var EMOrders = db.EmergencyMaintenances.Where(a => a.EMEndDate == null).ToList();
                Dictionary<long, string> EMOrderKvp = new Dictionary<long, string>();
                EMNumberBox.Items.Clear();
                foreach (var item in EMOrders)
                {
                    var ANEM = item.Asset.AssetName + $@"({item.ID})";
                    EMOrderKvp.Add(item.ID, ANEM);
                }
                EMNumberBox.DataSource = new BindingSource(EMOrderKvp, null);
                EMNumberBox.DisplayMember = "Value";
                EMNumberBox.ValueMember = "Key";

            }
        }
        private void loadEMStartDate()
        {
            //get date of EMOrder
            var currentAsset = ((KeyValuePair<long, string>)EMNumberBox.SelectedItem).Key;
            using (Session6Entities db = new Session6Entities())
            {
                var emsd = db.EmergencyMaintenances.Where(a => a.ID == currentAsset).Select(a => a.EMStartDate).FirstOrDefault();
                EMStartDatePicker.Value = Convert.ToDateTime(emsd);
            }
        }

        private void EMNumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadWarehouses()
        {
            using (Session6Entities db = new Session6Entities())
            {
                var warehouses = db.Warehouses.ToList();
                WarehouseBox.DataSource = new BindingSource(warehouses, null);
                WarehouseBox.DisplayMember = "Name";
                WarehouseBox.ValueMember = "ID";
                loadAvailableParts();
            }
        }
        private void loadAvailableParts()
        {
            using (Session6Entities db = new Session6Entities())
            {
                //SelectedWarehouse
                var warehouseID = ((Warehouse)WarehouseBox.SelectedItem).ID;
                PartsBox.DataSource = (from a in db.OrderItems
                                       where a.Order.TransactionTypeID == 1 && a.Order.DestinationWarehouseID == warehouseID
                                       group a by new { a.Part.Name, a.PartID } into b
                                       select new availablePartInfo()
                                       {
                                           ID = b.Key.PartID,
                                           Value = b.Key.Name,
                                           TotalAmount = b.Sum(a => a.Amount)
                                       }).ToList();
                PartsBox.DisplayMember = "Value";
                PartsBox.ValueMember = "ID";
            }
        }

        private void loadAllocationMethods()
        {
            List<string> allocationMethods = new List<string>(){ "FIFO", "LIFO", "Minimum First"};
            AllocationMethodBox.DataSource = new BindingSource(allocationMethods, null);
        }

        private void WarehouseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadAvailableParts();
        }

        private void PartsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var maxamt = Convert.ToDecimal((PartsBox.SelectedItem as availablePartInfo).TotalAmount);
            AmountBox.Tag = maxamt;
            amountLimit.Text = $"Available amount: {maxamt.ToString("0")}";
            amountLimit.Visible = true;
        }

        private void AllocateBtn_Click(object sender, EventArgs e)
        {
            var allocationMethod = AllocationMethodBox.SelectedValue.ToString();
            using(Session6Entities db = new Session6Entities())
            {
                var selectedPart = (PartsBox.SelectedItem as availablePartInfo).ID;
                var selectedWarehouse = (WarehouseBox.SelectedItem as Warehouse).ID;
                var availableItems = (from a in db.OrderItems
                                     where a.PartID == selectedPart && a.Order.DestinationWarehouseID == selectedWarehouse
                                     select new { OrderItem = a, a.Order }
                    );

                switch (allocationMethod)
                {
                    case "FIFO":
                        availableItems = (from p in availableItems
                                      orderby p.Order.Date 
                                         select p);
                        break;
                    case "LIFO":
                        availableItems = from p in availableItems
                                         orderby p.Order.Date descending
                                         select p;
                        break;
                    case "Minimum First":
                        availableItems = from p in availableItems
                                         orderby p.OrderItem.UnitPrice
                                         select p;
                        break;
                }
                var availableParts = (from p in availableItems
                                      select new partsTable()
                                      {
                                          PartName = p.OrderItem.Part.Name,
                                          BatchNumber = p.OrderItem.BatchNumber,
                                          UnitPrice = p.OrderItem.UnitPrice.Value,
                                          Amount = p.OrderItem.Amount,
                                          PartID = p.OrderItem.PartID
                                      }).Take(Convert.ToInt32(Math.Ceiling(AmountBox.Value)));

                var allocatedParts = new List<partsTable>();
                decimal currentAmt = 0;
                var requiredAmt = AmountBox.Value;
                while(currentAmt < requiredAmt)
                {
                    foreach(var item in availableParts)
                    {
                        if(item.Amount < requiredAmt)
                        {
                            allocatedParts.Add(item);
                            currentAmt = item.Amount;
                            break;
                        }
                        else if(item.Amount == requiredAmt)
                        {
                            allocatedParts.Add(item);
                            currentAmt = item.Amount;
                            break;
                        }
                    }
                }
                foreach(var item in allocatedParts)
                {
                    object[] row = new object[5];
                    row[0] = item.PartName;
                    row[1] = item.BatchNumber;
                    row[2] = item.UnitPrice;
                    row[3] = item.Amount;
                    row[4] = item.PartID;
                    AllocatedPartsDGV.Rows.Add(row);
                }

            }
            
        }
    }
    public class availablePartInfo
    {
        public long ID { get; set; }
        public string Value { get; set; }
        public decimal TotalAmount { get; set; }
    }

    public class partsTable
    {
        public string PartName { get; set; }
        public string BatchNumber { get; set; }
        public  decimal  UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public long PartID { get; set; }
    }
}
