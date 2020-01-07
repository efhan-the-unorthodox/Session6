using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Session6
{
    public partial class InventoryDashboard : Form
    {
        public InventoryDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void InventoryDashboard_Load(object sender, EventArgs e)
        {
            /*
             * Note to Mr Jeffery: I took some reference from your answer that you provided. I did not copy directly but say I did take some influence from your answer but I went to make my own adaptations
             * to which i felt I maybe did simplyfy but still got the same output. The following methods below which generates the 3 respective datagridviews for 
             * department spending, most used and costly parts as well as the costly assets with their respective department. These methods I have taken example from your code
             * 
             * I hope that what I did was somewhat alright
             * 
             * P.S I feel that this paper should take minimum 4 days and max a week to complete with the experience I have currently (If i were to do this paper from scratch without referencing your code)
             * 
             * 
             */
            generateDepartmentSpending();
            generatePartsAggregation();
            generateCostlyAssetsReport();
            generateDepartmentSpendingRatio();
            generateMonthlyDepartmentSpendingGraph();
        }

        //This method of cell formatting i also took some influence from your code but instead of using ondatabindingcomplete event i decided to use the cellformatting which i was already aware of and 
        //comfortable with. The algorithm and structure is also quite similar
        private void emDepartmentExpendituredgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var expDgv = (DataGridView)sender;

            var columns = expDgv.Rows[0].Cells.Count;

            var columnCount = expDgv.Columns.Count;

            var rowCount = expDgv.Rows.Count;

            for (var i = 1; i < columnCount; i++)
            {
                decimal minValue = int.MaxValue;
                int minIndex = -1;
                decimal maxValue = int.MinValue;
                int maxIndex = -1;

                for (var j = 0; j < rowCount; j++)
                {
                    var currentcellValue = Convert.ToDecimal(expDgv.Rows[j].Cells[i].Value);
                    //Console.WriteLine("Value at Column index " + i + " row index: " + j + " = " + cellValue.ToString());
                    if (currentcellValue > 0)
                    {
                        if (currentcellValue < minValue)
                        {
                            minValue = currentcellValue;
                            minIndex = j;
                        }
                        if (currentcellValue > maxValue)
                        {
                            maxValue = currentcellValue;
                            maxIndex = j;
                        }
                    }
                }
                if (minIndex == -1 && maxIndex == -1)
                {
                    //nothing happens
                }
                else if (minIndex == maxIndex)
                {
                    expDgv.Rows[maxIndex].Cells[i].Style.ForeColor = Color.Red;
                    expDgv.Rows[minIndex].Cells[i].Style.ForeColor = Color.Red;
                }
                else
                {
                    if (maxIndex > -1) expDgv.Rows[maxIndex].Cells[i].Style.ForeColor = Color.Red;
                    if (minIndex > -1) expDgv.Rows[minIndex].Cells[i].Style.ForeColor = Color.Green;
                }
            }
        }

        private void generateDepartmentSpending()
        {
            using (Session6Entities db = new Session6Entities())
            {
                //Retrieve total order expenditures classified by departments
                var all_orderexpenditures_by_depts = (from a in db.Orders
                                                      where a.EmergencyMaintenance.EMStartDate != null && a.EmergencyMaintenance.EMEndDate != null
                                                      select new
                                                      {
                                                          dept = a.EmergencyMaintenance.Asset.DepartmentLocation.Department,
                                                          dateOfOrder = a.Date,
                                                          totalSpending = a.OrderItems.Sum(s => s.Amount * s.UnitPrice)
                                                      }).ToList();
                var all_orderexpenditures_by_depts1 = (from a in all_orderexpenditures_by_depts
                                                       select new
                                                       {
                                                           deptName = a.dept.Name,
                                                           a.totalSpending,
                                                           date = a.dateOfOrder.ToString("yyyy-MM")
                                                       }).ToList();
                //to get list of departments
                var departmentlist = all_orderexpenditures_by_depts1.OrderBy(a => a.deptName).Select(a => a.deptName).Distinct();

                //to get list of months to fill columns for completed emergency maintainences and their expenditures
                var dateList = all_orderexpenditures_by_depts1.OrderByDescending(a => a.date).Select(a => a.date).Distinct();

                emDepartmentExpendituredgv.Rows.Clear();

                foreach (var emDate in dateList)
                {
                    var dateColumn = new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = emDate,
                        HeaderText = emDate
                    };
                    emDepartmentExpendituredgv.Columns.Add(dateColumn);

                }

                foreach (var dept in departmentlist)
                {
                    List<string> row = new List<string>();
                    row.Add(dept);
                    foreach (var expDate in dateList)
                    {
                        var totalexp = (from p in all_orderexpenditures_by_depts1
                                        where p.deptName == dept && p.date == expDate
                                        select p.totalSpending).Sum().Value.ToString("0");
                        row.Add(totalexp);
                    }
                    emDepartmentExpendituredgv.Rows.Add(row.ToArray());
                }
            }
        }

        private void generatePartsAggregation()
        {
            using (Session6Entities db = new Session6Entities())
            {
                //getting all orders
                var allparts_fromcompletedOrders = db.OrderItems.Where(a => a.Order.EmergencyMaintenance.EMEndDate != null && a.Order.EmergencyMaintenance.EMStartDate != null).ToList();

                var order_expenditures = (from o in allparts_fromcompletedOrders
                                          orderby o.Order.Date descending
                                          select new
                                          {
                                              partID = o.PartID,
                                              partName = o.Part.Name,
                                              amt = o.Amount,
                                              orderDate = o.Order.Date.ToString("yyyy-MM"),
                                              costOfparts = (o.Amount * o.UnitPrice)
                                          }).ToList();
                //generate the columns for the dates of the months containing all the completed emergency maintanence orders
                var dateColumns = order_expenditures.Select(o => o.orderDate).Distinct();

                partsAggregateDgv.Rows.Clear();
                partsAggregateDgv.Columns.Clear();
                var firstColumn = new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "HiLo",
                    HeaderText = $@"Notes\Month"
                };
                partsAggregateDgv.Columns.Add(firstColumn);

                foreach (var date in dateColumns)
                {
                    var dateColumn = new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = date,
                        HeaderText = date
                    };
                    partsAggregateDgv.Columns.Add(dateColumn);
                }

                List<string> highestCost = new List<string>();
                highestCost.Add("Highest Cost");
                List<string> mostUsed = new List<string>();
                mostUsed.Add("Most Used");

                //This query here gets the records grouped bt their order date and part and will also return the part's respective expenditure and their total parts used
                var monthlyreport_mostusedpart_highestCost = (from a in order_expenditures
                                                              group a by new { a.orderDate, a.partName } into b
                                                              select new
                                                              {
                                                                  b.Key.partName,
                                                                  b.Key.orderDate,
                                                                  TotalExpenditure = b.Sum(a => a.costOfparts),
                                                                  TotalPartsused = b.Sum(a => a.amt)
                                                              });

                foreach (var date in dateColumns)
                {
                    #region This code is to retrieve all parts with very high costs. The code structure will also be the same when generating the costly assets
                    //first line is to get the record value of the part expenditure
                    var highestcostrecord = monthlyreport_mostusedpart_highestCost.Where(a => a.orderDate == date).OrderByDescending(a => a.TotalExpenditure).Select(a => a.TotalExpenditure).FirstOrDefault();
                    /*second line is to get a stringed list of the parts that have incurred high costs. I previously made a mistake as to only retrieve one part that has the highest cost when 
                     * i realised that there can be more than one part with the highest record expenditure
                     */
                    var partsWithhighCosts = string.Join(",", (monthlyreport_mostusedpart_highestCost.Where(a => a.TotalExpenditure == highestcostrecord).Select(a => a.partName)));
                    //This last line then adds this string list of costly parts to a previously declared list which stores the most costly assets by month descending
                    highestCost.Add(partsWithhighCosts);

                    //The first line here is to retrieve the record value of the most used part
                    var mostusedpartrecord = monthlyreport_mostusedpart_highestCost.Where(a => a.orderDate == date).OrderByDescending(a => a.TotalPartsused).Select(a => a.TotalPartsused).FirstOrDefault();
                    // This second part i also made the same mistake previously for the highestcosts for parts. In this line of code, i get a stringed list of all the most used parts. Same concept as getting highest cost
                    var mostUsedParts = string.Join(",", (monthlyreport_mostusedpart_highestCost.Where(a => a.TotalPartsused == mostusedpartrecord).Select(a => a.partName)));
                    //As explained with highestCosts, this will also add the stringed list of most used parts to a list that will hold the most used parts by month descending
                    mostUsed.Add(mostUsedParts);
                    #endregion
                }
                //With regards to the lists which i added the records to, it will simply be added to the list which i declared up in line 173 and 175. I will then add this list to a row in the datagridview
                //after converting it to an array. First row is to show the highest cost while the second is to show the most used part. Both being shown by month as instructed
                partsAggregateDgv.Rows.Add(highestCost.ToArray());
                partsAggregateDgv.Rows.Add(mostUsed.ToArray());
            }
        }
        private void generateCostlyAssetsReport()
        {
            using (Session6Entities db = new Session6Entities())
            {
                //getting all order items associated with their respective maintainence order that has already been completed
                var orderItems_withCompletedEMRs = db.OrderItems.Where(a => a.Order.EmergencyMaintenance.EMStartDate != null & a.Order.EmergencyMaintenance.EMEndDate != null).ToList();

                var orderItems_withCompletedEMRs2 = (from a in orderItems_withCompletedEMRs
                                                     orderby a.Order.Date descending
                                                     select new
                                                     {
                                                         orderDate = a.Order.Date.ToString("yyyy-MM"),
                                                         deptName = a.Order.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name,
                                                         partTotalCost = a.Amount * a.UnitPrice,
                                                         partName = a.Part.Name
                                                     }).ToList();

                List<string> listmostcostlyAssetsbymonth = new List<string>();
                listmostcostlyAssetsbymonth.Add("Asset");
                List<string> listcostlyassetAssociatedDepartments = new List<string>();
                listcostlyassetAssociatedDepartments.Add("Department");

                var dateColumns = orderItems_withCompletedEMRs2.Select(a => a.orderDate).Distinct();

                mostCostlyAssetsDgv.Rows.Clear();
                mostCostlyAssetsDgv.Columns.Clear();
                var firstColumn = new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "CostlyAssets",
                    HeaderText = $@"Asset Name\Month"
                };
                mostCostlyAssetsDgv.Columns.Add(firstColumn);


                foreach (var date in dateColumns)
                {
                    mostCostlyAssetsDgv.Columns.Add(new DataGridViewTextBoxColumn()
                    {
                        DataPropertyName = date,
                        HeaderText = date
                    });
                }

                var monthlyReportOfCostlyAssets = (from a in orderItems_withCompletedEMRs2
                                                   group a by new { a.orderDate, a.partName, a.deptName } into b
                                                   select new
                                                   {
                                                       b.Key.orderDate,
                                                       b.Key.deptName,
                                                       b.Key.partName,
                                                       TotalCost = b.Sum(a => a.partTotalCost)
                                                   });

                foreach (var date in dateColumns)
                {
                    var highestCostbyMonth = (from a in monthlyReportOfCostlyAssets
                                              where a.orderDate == date
                                              orderby a.TotalCost descending
                                              select a.TotalCost).FirstOrDefault();

                    //checker to check if there is another department with an equally costly asset. THis part was also influenced by Mr Jeffery
                    var costlyassetsbymonth = string.Join(",", (from a in monthlyReportOfCostlyAssets
                                                                where a.TotalCost == highestCostbyMonth
                                                                select a.partName));
                    var departmentAssociatedwithCostlyAsset = string.Join(",", (from a in monthlyReportOfCostlyAssets
                                                                                where a.TotalCost == highestCostbyMonth
                                                                                select a.deptName));
                    listmostcostlyAssetsbymonth.Add(costlyassetsbymonth);
                    listcostlyassetAssociatedDepartments.Add(departmentAssociatedwithCostlyAsset);
                }
                mostCostlyAssetsDgv.Rows.Add(listmostcostlyAssetsbymonth.ToArray());
                mostCostlyAssetsDgv.Rows.Add(listcostlyassetAssociatedDepartments.ToArray());
            }
        }
        private void generateDepartmentSpendingRatio()
        {
            //getting all orderitems and categorising them by their departments
            using (Session6Entities db = new Session6Entities())
            {
                var allOrderItemsExpenditure = db.OrderItems.Where(a => a.Order.EmergencyMaintenance.EMEndDate != null && a.Order.EmergencyMaintenance.EMStartDate != null).ToList();

                var orderItemsExpwithDept = (from a in allOrderItemsExpenditure
                                             group a by a.Order.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name into b
                                             select new
                                             {
                                                 deptName = b.Key,
                                                 TotalExpenditure = b.Sum(a => a.Amount * a.UnitPrice).Value
                                             }).ToList();
                deptSpendingRatioPie.Series[0].Points.Clear();
                foreach (var item in orderItemsExpwithDept)
                {
                    var portion = deptSpendingRatioPie.Series[0].Points.AddY(item.TotalExpenditure);
                    deptSpendingRatioPie.Series[0].Points[portion].LegendText = item.deptName;
                    deptSpendingRatioPie.Series[0].Points[portion].Label = " ";
                }
            }
        }
        private void generateMonthlyDepartmentSpendingGraph()
        {
            using (Session6Entities db = new Session6Entities())
            {
                var getAllOrderItems1 = (from a in db.OrderItems
                                         orderby a.Order.Date descending
                                         where a.Order.EmergencyMaintenance.EMEndDate != null && a.Order.EmergencyMaintenance.EMStartDate != null
                                         select new
                                         {
                                             DepartmentName = a.Order.EmergencyMaintenance.Asset.DepartmentLocation.Department.Name,
                                             OrderDate = a.Order.Date,
                                             TotalCostOfOrderItem = a.Amount * a.UnitPrice
                                         }).ToList();
                var getAllOrderItems = (from a in getAllOrderItems1
                                        select new
                                        {
                                            a.DepartmentName,
                                            OrderDate = a.OrderDate.ToString("yyyy-MM"),
                                            a.TotalCostOfOrderItem,
                                        }).ToList();

                var departmentExpenditurebymonth = (from a in getAllOrderItems
                                                    group a by new { a.DepartmentName, a.OrderDate } into b
                                                    select new
                                                    {
                                                        b.Key.DepartmentName,
                                                        b.Key.OrderDate,
                                                        TotalDeptExp = b.Sum(a => a.TotalCostOfOrderItem)
                                                    }
                    );
                monthlyDeptSpendingGraph.Series.Clear();
                foreach (var deptName in departmentExpenditurebymonth.Select(p => p.DepartmentName).Distinct())
                {
                    monthlyDeptSpendingGraph.Series.Add(new System.Windows.Forms.DataVisualization.Charting.Series(deptName) { });
                }
                var curDate = " ";
                var dateIdx = 0;
                foreach(var r in departmentExpenditurebymonth)
                {
                    if(curDate != r.OrderDate)
                    {
                        curDate = r.OrderDate;
                        dateIdx++;
                    }
                    var idx = monthlyDeptSpendingGraph.Series[r.DepartmentName].Points.AddXY(dateIdx, r.TotalDeptExp);
                    monthlyDeptSpendingGraph.Series[r.DepartmentName].Points[idx].AxisLabel = r.OrderDate;
                    monthlyDeptSpendingGraph.Series[r.DepartmentName].Points[idx].Label = r.TotalDeptExp.Value.ToString("#,##0");
                }



            }
        }

        private void InventoryControlBtn_Click(object sender, EventArgs e)
        {
            InventoryControl inventoryControl = new InventoryControl();
            inventoryControl.ShowDialog();
        }
    }
}
