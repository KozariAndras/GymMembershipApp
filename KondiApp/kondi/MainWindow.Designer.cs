namespace kondi
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddNewMember = new System.Windows.Forms.Button();
            this.buttonManageMembers = new System.Windows.Forms.Button();
            this.buttonShowActiveMembers = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonShowPassiveMembers = new System.Windows.Forms.Button();
            this.buttonValidMemberships = new System.Windows.Forms.Button();
            this.buttonExpiredMemberships = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonShowAllMembers = new System.Windows.Forms.Button();
            this.buttonMembershipsOfSelected = new System.Windows.Forms.Button();
            this.chartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gym Membership Manager";
            // 
            // buttonAddNewMember
            // 
            this.buttonAddNewMember.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAddNewMember.Location = new System.Drawing.Point(24, 116);
            this.buttonAddNewMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddNewMember.Name = "buttonAddNewMember";
            this.buttonAddNewMember.Size = new System.Drawing.Size(173, 36);
            this.buttonAddNewMember.TabIndex = 1;
            this.buttonAddNewMember.Text = "Add new member";
            this.buttonAddNewMember.UseVisualStyleBackColor = false;
            this.buttonAddNewMember.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonManageMembers
            // 
            this.buttonManageMembers.BackColor = System.Drawing.SystemColors.Window;
            this.buttonManageMembers.Location = new System.Drawing.Point(24, 160);
            this.buttonManageMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonManageMembers.Name = "buttonManageMembers";
            this.buttonManageMembers.Size = new System.Drawing.Size(173, 36);
            this.buttonManageMembers.TabIndex = 2;
            this.buttonManageMembers.Text = "Manage member(s)";
            this.buttonManageMembers.UseVisualStyleBackColor = false;
            this.buttonManageMembers.Click += new System.EventHandler(this.buttonManageMembers_Click);
            // 
            // buttonShowActiveMembers
            // 
            this.buttonShowActiveMembers.BackColor = System.Drawing.SystemColors.Window;
            this.buttonShowActiveMembers.Location = new System.Drawing.Point(24, 277);
            this.buttonShowActiveMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShowActiveMembers.Name = "buttonShowActiveMembers";
            this.buttonShowActiveMembers.Size = new System.Drawing.Size(173, 36);
            this.buttonShowActiveMembers.TabIndex = 3;
            this.buttonShowActiveMembers.Text = "Show active members";
            this.buttonShowActiveMembers.UseVisualStyleBackColor = false;
            this.buttonShowActiveMembers.Click += new System.EventHandler(this.buttonShowActiveMembers_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(216, 104);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(636, 164);
            this.listBox1.TabIndex = 4;
            this.listBox1.Click += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonShowPassiveMembers
            // 
            this.buttonShowPassiveMembers.BackColor = System.Drawing.SystemColors.Window;
            this.buttonShowPassiveMembers.Location = new System.Drawing.Point(24, 321);
            this.buttonShowPassiveMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShowPassiveMembers.Name = "buttonShowPassiveMembers";
            this.buttonShowPassiveMembers.Size = new System.Drawing.Size(173, 36);
            this.buttonShowPassiveMembers.TabIndex = 5;
            this.buttonShowPassiveMembers.Text = "Show passive members";
            this.buttonShowPassiveMembers.UseVisualStyleBackColor = false;
            this.buttonShowPassiveMembers.Click += new System.EventHandler(this.buttonShowPassiveMembers_Click);
            // 
            // buttonValidMemberships
            // 
            this.buttonValidMemberships.BackColor = System.Drawing.SystemColors.Window;
            this.buttonValidMemberships.Location = new System.Drawing.Point(24, 397);
            this.buttonValidMemberships.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonValidMemberships.Name = "buttonValidMemberships";
            this.buttonValidMemberships.Size = new System.Drawing.Size(173, 36);
            this.buttonValidMemberships.TabIndex = 6;
            this.buttonValidMemberships.Text = "Valid memberships";
            this.buttonValidMemberships.UseVisualStyleBackColor = false;
            this.buttonValidMemberships.Click += new System.EventHandler(this.buttonValidMemberships_Click);
            // 
            // buttonExpiredMemberships
            // 
            this.buttonExpiredMemberships.BackColor = System.Drawing.SystemColors.Window;
            this.buttonExpiredMemberships.Location = new System.Drawing.Point(24, 441);
            this.buttonExpiredMemberships.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExpiredMemberships.Name = "buttonExpiredMemberships";
            this.buttonExpiredMemberships.Size = new System.Drawing.Size(173, 36);
            this.buttonExpiredMemberships.TabIndex = 7;
            this.buttonExpiredMemberships.Text = "Expired memberships";
            this.buttonExpiredMemberships.UseVisualStyleBackColor = false;
            this.buttonExpiredMemberships.Click += new System.EventHandler(this.buttonExpiredMemberships_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(216, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sold memberships";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(315, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "GRAFIKON HELYE";
            // 
            // buttonShowAllMembers
            // 
            this.buttonShowAllMembers.BackColor = System.Drawing.SystemColors.Window;
            this.buttonShowAllMembers.Location = new System.Drawing.Point(24, 233);
            this.buttonShowAllMembers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShowAllMembers.Name = "buttonShowAllMembers";
            this.buttonShowAllMembers.Size = new System.Drawing.Size(173, 36);
            this.buttonShowAllMembers.TabIndex = 10;
            this.buttonShowAllMembers.Text = "Show all members";
            this.buttonShowAllMembers.UseVisualStyleBackColor = false;
            this.buttonShowAllMembers.Click += new System.EventHandler(this.buttonShowAllMembers_Click);
            // 
            // buttonMembershipsOfSelected
            // 
            this.buttonMembershipsOfSelected.BackColor = System.Drawing.SystemColors.Window;
            this.buttonMembershipsOfSelected.Enabled = false;
            this.buttonMembershipsOfSelected.Location = new System.Drawing.Point(734, 276);
            this.buttonMembershipsOfSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMembershipsOfSelected.Name = "buttonMembershipsOfSelected";
            this.buttonMembershipsOfSelected.Size = new System.Drawing.Size(118, 36);
            this.buttonMembershipsOfSelected.TabIndex = 11;
            this.buttonMembershipsOfSelected.Text = "Memberships";
            this.buttonMembershipsOfSelected.UseVisualStyleBackColor = false;
            this.buttonMembershipsOfSelected.Click += new System.EventHandler(this.buttonMembershipsOfSelected_Click);
            // 
            // chartSales
            // 
            this.chartSales.BorderlineColor = System.Drawing.Color.Silver;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "Sales";
            this.chartSales.ChartAreas.Add(chartArea1);
            this.chartSales.Location = new System.Drawing.Point(216, 321);
            this.chartSales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartSales.Name = "chartSales";
            series1.ChartArea = "Sales";
            series1.LabelAngle = 90;
            series1.Name = "Sales";
            this.chartSales.Series.Add(series1);
            this.chartSales.Size = new System.Drawing.Size(636, 245);
            this.chartSales.TabIndex = 12;
            this.chartSales.Text = "chart1";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.DockedToChartArea = "Sales";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Name = "Sales";
            title1.Visible = false;
            this.chartSales.Titles.Add(title1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(894, 599);
            this.Controls.Add(this.chartSales);
            this.Controls.Add(this.buttonMembershipsOfSelected);
            this.Controls.Add(this.buttonShowAllMembers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExpiredMemberships);
            this.Controls.Add(this.buttonValidMemberships);
            this.Controls.Add(this.buttonShowPassiveMembers);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonShowActiveMembers);
            this.Controls.Add(this.buttonManageMembers);
            this.Controls.Add(this.buttonAddNewMember);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Gym Main Window";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.chartSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonAddNewMember;
        private Button buttonManageMembers;
        private Button buttonShowActiveMembers;
        private ListBox listBox1;
        private Button buttonShowPassiveMembers;
        private Button buttonValidMemberships;
        private Button buttonExpiredMemberships;
        private Label label2;
        private Label label3;
        private Button buttonShowAllMembers;
        private Button buttonMembershipsOfSelected;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSales;
    }
}