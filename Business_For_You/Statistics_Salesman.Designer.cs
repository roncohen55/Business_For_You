
namespace Business_For_You
{
    partial class Statistics_Salesman
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics_Salesman));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panelCountSale = new System.Windows.Forms.Panel();
            this.lblinfoCount = new System.Windows.Forms.Label();
            this.lblCountSales = new System.Windows.Forms.Label();
            this.panelSale = new System.Windows.Forms.Panel();
            this.lblinfoSales = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4.SuspendLayout();
            this.panelCountSale.SuspendLayout();
            this.panelSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1259, 47);
            this.panel4.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(496, 17);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "סטטיסטיקה";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "יומי",
            "חודשי",
            "שנתי"});
            this.comboBox1.Location = new System.Drawing.Point(784, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(153, 30);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Text = "יומי";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(600, 94);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxDate.Size = new System.Drawing.Size(153, 30);
            this.comboBoxDate.TabIndex = 28;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.Window;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnInfo.Location = new System.Drawing.Point(483, 92);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(91, 31);
            this.btnInfo.TabIndex = 38;
            this.btnInfo.Text = "הצג מידע";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panelCountSale
            // 
            this.panelCountSale.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelCountSale.Controls.Add(this.lblinfoCount);
            this.panelCountSale.Controls.Add(this.lblCountSales);
            this.panelCountSale.Location = new System.Drawing.Point(703, 555);
            this.panelCountSale.Name = "panelCountSale";
            this.panelCountSale.Size = new System.Drawing.Size(213, 120);
            this.panelCountSale.TabIndex = 39;
            // 
            // lblinfoCount
            // 
            this.lblinfoCount.AutoSize = true;
            this.lblinfoCount.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblinfoCount.Location = new System.Drawing.Point(91, 63);
            this.lblinfoCount.Name = "lblinfoCount";
            this.lblinfoCount.Size = new System.Drawing.Size(24, 26);
            this.lblinfoCount.TabIndex = 22;
            this.lblinfoCount.Text = "0";
            // 
            // lblCountSales
            // 
            this.lblCountSales.AutoSize = true;
            this.lblCountSales.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCountSales.ForeColor = System.Drawing.Color.Black;
            this.lblCountSales.Location = new System.Drawing.Point(42, 21);
            this.lblCountSales.Name = "lblCountSales";
            this.lblCountSales.Size = new System.Drawing.Size(116, 26);
            this.lblCountSales.TabIndex = 21;
            this.lblCountSales.Text = "כמות מכירות";
            // 
            // panelSale
            // 
            this.panelSale.BackColor = System.Drawing.Color.LawnGreen;
            this.panelSale.Controls.Add(this.lblinfoSales);
            this.panelSale.Controls.Add(this.lblSales);
            this.panelSale.Location = new System.Drawing.Point(390, 555);
            this.panelSale.Name = "panelSale";
            this.panelSale.Size = new System.Drawing.Size(213, 120);
            this.panelSale.TabIndex = 40;
            // 
            // lblinfoSales
            // 
            this.lblinfoSales.AutoSize = true;
            this.lblinfoSales.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblinfoSales.Location = new System.Drawing.Point(65, 63);
            this.lblinfoSales.Name = "lblinfoSales";
            this.lblinfoSales.Size = new System.Drawing.Size(42, 26);
            this.lblinfoSales.TabIndex = 23;
            this.lblinfoSales.Text = "₪0";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSales.ForeColor = System.Drawing.Color.Black;
            this.lblSales.Location = new System.Drawing.Point(61, 21);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(70, 26);
            this.lblSales.TabIndex = 18;
            this.lblSales.Text = "מכירות";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(346, 159);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "תזרים המכירות שלך";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(591, 363);
            this.chart1.TabIndex = 43;
            this.chart1.Text = "chart1";
            // 
            // Statistics_Salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 765);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panelSale);
            this.Controls.Add(this.panelCountSale);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics_Salesman";
            this.Text = "Statistics_Salesman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelCountSale.ResumeLayout(false);
            this.panelCountSale.PerformLayout();
            this.panelSale.ResumeLayout(false);
            this.panelSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panelCountSale;
        private System.Windows.Forms.Label lblinfoCount;
        private System.Windows.Forms.Label lblCountSales;
        private System.Windows.Forms.Panel panelSale;
        private System.Windows.Forms.Label lblinfoSales;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}