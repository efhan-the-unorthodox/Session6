namespace Session6
{
    partial class InventoryControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EMNumberBox = new System.Windows.Forms.ComboBox();
            this.EMStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllocateBtn = new System.Windows.Forms.Button();
            this.AllocationMethodBox = new System.Windows.Forms.ComboBox();
            this.AmountBox = new System.Windows.Forms.NumericUpDown();
            this.PartsBox = new System.Windows.Forms.ComboBox();
            this.WarehouseBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AllocatedPartsDGV = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AssignedPartsDGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.amountLimit = new System.Windows.Forms.Label();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllocatedPartsDGV)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AssignedPartsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset Number (EM Number):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date: ";
            // 
            // EMNumberBox
            // 
            this.EMNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMNumberBox.FormattingEnabled = true;
            this.EMNumberBox.Location = new System.Drawing.Point(220, 21);
            this.EMNumberBox.Name = "EMNumberBox";
            this.EMNumberBox.Size = new System.Drawing.Size(253, 26);
            this.EMNumberBox.TabIndex = 2;
            this.EMNumberBox.SelectedIndexChanged += new System.EventHandler(this.EMNumberBox_SelectedIndexChanged);
            // 
            // EMStartDatePicker
            // 
            this.EMStartDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMStartDatePicker.Location = new System.Drawing.Point(545, 21);
            this.EMStartDatePicker.Name = "EMStartDatePicker";
            this.EMStartDatePicker.Size = new System.Drawing.Size(313, 24);
            this.EMStartDatePicker.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.amountLimit);
            this.groupBox1.Controls.Add(this.AllocateBtn);
            this.groupBox1.Controls.Add(this.AllocationMethodBox);
            this.groupBox1.Controls.Add(this.AmountBox);
            this.groupBox1.Controls.Add(this.PartsBox);
            this.groupBox1.Controls.Add(this.WarehouseBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search for parts";
            // 
            // AllocateBtn
            // 
            this.AllocateBtn.Location = new System.Drawing.Point(779, 97);
            this.AllocateBtn.Name = "AllocateBtn";
            this.AllocateBtn.Size = new System.Drawing.Size(75, 29);
            this.AllocateBtn.TabIndex = 9;
            this.AllocateBtn.Text = "Allocate";
            this.AllocateBtn.UseVisualStyleBackColor = true;
            this.AllocateBtn.Click += new System.EventHandler(this.AllocateBtn_Click);
            // 
            // AllocationMethodBox
            // 
            this.AllocationMethodBox.FormattingEnabled = true;
            this.AllocationMethodBox.Location = new System.Drawing.Point(584, 100);
            this.AllocationMethodBox.Name = "AllocationMethodBox";
            this.AllocationMethodBox.Size = new System.Drawing.Size(164, 26);
            this.AllocationMethodBox.TabIndex = 8;
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(318, 100);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(120, 24);
            this.AmountBox.TabIndex = 7;
            // 
            // PartsBox
            // 
            this.PartsBox.FormattingEnabled = true;
            this.PartsBox.Location = new System.Drawing.Point(99, 97);
            this.PartsBox.Name = "PartsBox";
            this.PartsBox.Size = new System.Drawing.Size(140, 26);
            this.PartsBox.TabIndex = 6;
            this.PartsBox.SelectedIndexChanged += new System.EventHandler(this.PartsBox_SelectedIndexChanged);
            // 
            // WarehouseBox
            // 
            this.WarehouseBox.FormattingEnabled = true;
            this.WarehouseBox.Location = new System.Drawing.Point(109, 41);
            this.WarehouseBox.Name = "WarehouseBox";
            this.WarehouseBox.Size = new System.Drawing.Size(301, 26);
            this.WarehouseBox.TabIndex = 5;
            this.WarehouseBox.SelectedIndexChanged += new System.EventHandler(this.WarehouseBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(245, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Amount: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(448, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Allocation Method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Part Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Warehouse: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.AllocatedPartsDGV);
            this.groupBox2.Location = new System.Drawing.Point(17, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 180);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Allocated Parts";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(726, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Assign to EM";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AllocatedPartsDGV
            // 
            this.AllocatedPartsDGV.AllowUserToAddRows = false;
            this.AllocatedPartsDGV.AllowUserToDeleteRows = false;
            this.AllocatedPartsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllocatedPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllocatedPartsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartName,
            this.BatchNumber,
            this.UnitPrice,
            this.Amount,
            this.PartID});
            this.AllocatedPartsDGV.Location = new System.Drawing.Point(13, 24);
            this.AllocatedPartsDGV.Name = "AllocatedPartsDGV";
            this.AllocatedPartsDGV.ReadOnly = true;
            this.AllocatedPartsDGV.RowHeadersWidth = 51;
            this.AllocatedPartsDGV.RowTemplate.Height = 24;
            this.AllocatedPartsDGV.Size = new System.Drawing.Size(693, 150);
            this.AllocatedPartsDGV.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AssignedPartsDGV);
            this.groupBox3.Location = new System.Drawing.Point(17, 434);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(860, 203);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assigned Parts";
            // 
            // AssignedPartsDGV
            // 
            this.AssignedPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignedPartsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignedPartsDGV.Location = new System.Drawing.Point(3, 18);
            this.AssignedPartsDGV.Name = "AssignedPartsDGV";
            this.AssignedPartsDGV.RowHeadersWidth = 51;
            this.AssignedPartsDGV.RowTemplate.Height = 24;
            this.AssignedPartsDGV.Size = new System.Drawing.Size(854, 182);
            this.AssignedPartsDGV.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(265, 643);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(419, 643);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // amountLimit
            // 
            this.amountLimit.AutoSize = true;
            this.amountLimit.ForeColor = System.Drawing.Color.Red;
            this.amountLimit.Location = new System.Drawing.Point(315, 79);
            this.amountLimit.Name = "amountLimit";
            this.amountLimit.Size = new System.Drawing.Size(90, 18);
            this.amountLimit.TabIndex = 10;
            this.amountLimit.Text = "AmountLimit";
            this.amountLimit.Visible = false;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Part Name";
            this.PartName.MinimumWidth = 6;
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            // 
            // BatchNumber
            // 
            this.BatchNumber.HeaderText = "Batch Number";
            this.BatchNumber.MinimumWidth = 6;
            this.BatchNumber.Name = "BatchNumber";
            this.BatchNumber.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // PartID
            // 
            this.PartID.HeaderText = "PartID";
            this.PartID.MinimumWidth = 6;
            this.PartID.Name = "PartID";
            this.PartID.ReadOnly = true;
            this.PartID.Visible = false;
            // 
            // InventoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 683);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EMStartDatePicker);
            this.Controls.Add(this.EMNumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InventoryControl";
            this.Text = "InventoryControl";
            this.Load += new System.EventHandler(this.InventoryControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllocatedPartsDGV)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AssignedPartsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EMNumberBox;
        private System.Windows.Forms.DateTimePicker EMStartDatePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AllocateBtn;
        private System.Windows.Forms.ComboBox AllocationMethodBox;
        private System.Windows.Forms.NumericUpDown AmountBox;
        private System.Windows.Forms.ComboBox PartsBox;
        private System.Windows.Forms.ComboBox WarehouseBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView AllocatedPartsDGV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView AssignedPartsDGV;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label amountLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartID;
    }
}