namespace Session6
{
    partial class InventoryDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emDepartmentExpendituredgv = new System.Windows.Forms.DataGridView();
            this.Departments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.partsAggregateDgv = new System.Windows.Forms.DataGridView();
            this.Costings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mostCostlyAssetsDgv = new System.Windows.Forms.DataGridView();
            this.CostlyAssetDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryControlBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.deptSpendingRatioPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthlyDeptSpendingGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emDepartmentExpendituredgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsAggregateDgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostCostlyAssetsDgv)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deptSpendingRatioPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDeptSpendingGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emDepartmentExpendituredgv);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1085, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EM Spending by Department";
            // 
            // emDepartmentExpendituredgv
            // 
            this.emDepartmentExpendituredgv.AllowUserToAddRows = false;
            this.emDepartmentExpendituredgv.AllowUserToDeleteRows = false;
            this.emDepartmentExpendituredgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emDepartmentExpendituredgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departments});
            this.emDepartmentExpendituredgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emDepartmentExpendituredgv.Location = new System.Drawing.Point(3, 18);
            this.emDepartmentExpendituredgv.Name = "emDepartmentExpendituredgv";
            this.emDepartmentExpendituredgv.ReadOnly = true;
            this.emDepartmentExpendituredgv.RowHeadersVisible = false;
            this.emDepartmentExpendituredgv.RowHeadersWidth = 51;
            this.emDepartmentExpendituredgv.RowTemplate.Height = 24;
            this.emDepartmentExpendituredgv.Size = new System.Drawing.Size(1079, 219);
            this.emDepartmentExpendituredgv.TabIndex = 0;
            this.emDepartmentExpendituredgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.emDepartmentExpendituredgv_CellFormatting);
            // 
            // Departments
            // 
            this.Departments.HeaderText = "Departments\\Month";
            this.Departments.MinimumWidth = 6;
            this.Departments.Name = "Departments";
            this.Departments.ReadOnly = true;
            this.Departments.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.partsAggregateDgv);
            this.groupBox2.Location = new System.Drawing.Point(22, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1085, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Monthly Report for Most-Used Parts";
            // 
            // partsAggregateDgv
            // 
            this.partsAggregateDgv.AllowUserToAddRows = false;
            this.partsAggregateDgv.AllowUserToDeleteRows = false;
            this.partsAggregateDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsAggregateDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Costings});
            this.partsAggregateDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partsAggregateDgv.Location = new System.Drawing.Point(3, 18);
            this.partsAggregateDgv.Name = "partsAggregateDgv";
            this.partsAggregateDgv.ReadOnly = true;
            this.partsAggregateDgv.RowHeadersWidth = 51;
            this.partsAggregateDgv.RowTemplate.Height = 24;
            this.partsAggregateDgv.Size = new System.Drawing.Size(1079, 245);
            this.partsAggregateDgv.TabIndex = 1;
            // 
            // Costings
            // 
            this.Costings.HeaderText = "Notes\\Month";
            this.Costings.MinimumWidth = 6;
            this.Costings.Name = "Costings";
            this.Costings.ReadOnly = true;
            this.Costings.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.mostCostlyAssetsDgv);
            this.groupBox3.Location = new System.Drawing.Point(22, 547);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1085, 205);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monthly Report of Costly Assets";
            // 
            // mostCostlyAssetsDgv
            // 
            this.mostCostlyAssetsDgv.AllowUserToAddRows = false;
            this.mostCostlyAssetsDgv.AllowUserToDeleteRows = false;
            this.mostCostlyAssetsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostCostlyAssetsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostlyAssetDept});
            this.mostCostlyAssetsDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mostCostlyAssetsDgv.Location = new System.Drawing.Point(3, 18);
            this.mostCostlyAssetsDgv.Name = "mostCostlyAssetsDgv";
            this.mostCostlyAssetsDgv.ReadOnly = true;
            this.mostCostlyAssetsDgv.RowHeadersWidth = 51;
            this.mostCostlyAssetsDgv.RowTemplate.Height = 24;
            this.mostCostlyAssetsDgv.Size = new System.Drawing.Size(1079, 184);
            this.mostCostlyAssetsDgv.TabIndex = 2;
            // 
            // CostlyAssetDept
            // 
            this.CostlyAssetDept.HeaderText = "Asset Name\\ Month";
            this.CostlyAssetDept.MinimumWidth = 6;
            this.CostlyAssetDept.Name = "CostlyAssetDept";
            this.CostlyAssetDept.ReadOnly = true;
            this.CostlyAssetDept.Width = 125;
            // 
            // InventoryControlBtn
            // 
            this.InventoryControlBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InventoryControlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryControlBtn.Location = new System.Drawing.Point(25, 769);
            this.InventoryControlBtn.Name = "InventoryControlBtn";
            this.InventoryControlBtn.Size = new System.Drawing.Size(178, 33);
            this.InventoryControlBtn.TabIndex = 2;
            this.InventoryControlBtn.Text = "Inventory Control";
            this.InventoryControlBtn.UseVisualStyleBackColor = true;
            this.InventoryControlBtn.Click += new System.EventHandler(this.InventoryControlBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(237, 769);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deptSpendingRatioPie);
            this.groupBox4.Location = new System.Drawing.Point(1126, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(372, 354);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Department Spending Ratio";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.monthlyDeptSpendingGraph);
            this.groupBox5.Location = new System.Drawing.Point(1126, 383);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(713, 419);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Monthly Department Spending";
            // 
            // deptSpendingRatioPie
            // 
            chartArea3.Name = "ChartArea1";
            this.deptSpendingRatioPie.ChartAreas.Add(chartArea3);
            this.deptSpendingRatioPie.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.deptSpendingRatioPie.Legends.Add(legend3);
            this.deptSpendingRatioPie.Location = new System.Drawing.Point(3, 18);
            this.deptSpendingRatioPie.Name = "deptSpendingRatioPie";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.deptSpendingRatioPie.Series.Add(series3);
            this.deptSpendingRatioPie.Size = new System.Drawing.Size(366, 333);
            this.deptSpendingRatioPie.TabIndex = 0;
            this.deptSpendingRatioPie.Text = "chart1";
            // 
            // monthlyDeptSpendingGraph
            // 
            chartArea4.Name = "ChartArea1";
            this.monthlyDeptSpendingGraph.ChartAreas.Add(chartArea4);
            this.monthlyDeptSpendingGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.monthlyDeptSpendingGraph.Legends.Add(legend4);
            this.monthlyDeptSpendingGraph.Location = new System.Drawing.Point(3, 18);
            this.monthlyDeptSpendingGraph.Name = "monthlyDeptSpendingGraph";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.monthlyDeptSpendingGraph.Series.Add(series4);
            this.monthlyDeptSpendingGraph.Size = new System.Drawing.Size(707, 398);
            this.monthlyDeptSpendingGraph.TabIndex = 0;
            this.monthlyDeptSpendingGraph.Text = "chart1";
            // 
            // InventoryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1851, 814);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InventoryControlBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InventoryDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Dashboard";
            this.Load += new System.EventHandler(this.InventoryDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emDepartmentExpendituredgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partsAggregateDgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mostCostlyAssetsDgv)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deptSpendingRatioPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyDeptSpendingGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button InventoryControlBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView emDepartmentExpendituredgv;
        private System.Windows.Forms.DataGridView partsAggregateDgv;
        private System.Windows.Forms.DataGridView mostCostlyAssetsDgv;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costings;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostlyAssetDept;
        private System.Windows.Forms.DataVisualization.Charting.Chart deptSpendingRatioPie;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthlyDeptSpendingGraph;
    }
}

