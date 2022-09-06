
namespace Business_For_You
{
    partial class Statistics_Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics_Manage));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.lblCountSales = new System.Windows.Forms.Label();
            this.lblinfoCount = new System.Windows.Forms.Label();
            this.lblinfoSales = new System.Windows.Forms.Label();
            this.lblinfoExpo = new System.Windows.Forms.Label();
            this.lblinfoProfit = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelCountSale = new System.Windows.Forms.Panel();
            this.panelProfit = new System.Windows.Forms.Panel();
            this.panelSale = new System.Windows.Forms.Panel();
            this.panelExpo = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4.SuspendLayout();
            this.panelCountSale.SuspendLayout();
            this.panelProfit.SuspendLayout();
            this.panelSale.SuspendLayout();
            this.panelExpo.SuspendLayout();
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
            this.panel4.Size = new System.Drawing.Size(1195, 47);
            this.panel4.TabIndex = 15;
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
            this.label3.Location = new System.Drawing.Point(486, 12);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "סטטיסטיקה";
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblProfit.ForeColor = System.Drawing.Color.Black;
            this.lblProfit.Location = new System.Drawing.Point(73, 21);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(48, 26);
            this.lblProfit.TabIndex = 16;
            this.lblProfit.Text = "רווח";
            this.lblProfit.Click += new System.EventHandler(this.lblProfit_Click);
            // 
            // lblExpenses
            // 
            this.lblExpenses.AutoSize = true;
            this.lblExpenses.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblExpenses.ForeColor = System.Drawing.Color.Black;
            this.lblExpenses.Location = new System.Drawing.Point(64, 18);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Size = new System.Drawing.Size(72, 26);
            this.lblExpenses.TabIndex = 17;
            this.lblExpenses.Text = "הוצאות";
            this.lblExpenses.Click += new System.EventHandler(this.lblExpenses_Click);
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
            this.lblSales.Click += new System.EventHandler(this.lblSales_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(396, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "הצג מידע";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Location = new System.Drawing.Point(505, 102);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxDate.Size = new System.Drawing.Size(157, 30);
            this.comboBoxDate.TabIndex = 20;
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
            this.lblCountSales.Click += new System.EventHandler(this.lblCountSales_Click);
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
            this.lblinfoCount.Click += new System.EventHandler(this.lblinfoCount_Click);
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
            this.lblinfoSales.Click += new System.EventHandler(this.lblinfoSales_Click);
            // 
            // lblinfoExpo
            // 
            this.lblinfoExpo.AutoSize = true;
            this.lblinfoExpo.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblinfoExpo.Location = new System.Drawing.Point(67, 59);
            this.lblinfoExpo.Name = "lblinfoExpo";
            this.lblinfoExpo.Size = new System.Drawing.Size(42, 26);
            this.lblinfoExpo.TabIndex = 24;
            this.lblinfoExpo.Text = "₪0";
            this.lblinfoExpo.Click += new System.EventHandler(this.lblinfoExpo_Click);
            // 
            // lblinfoProfit
            // 
            this.lblinfoProfit.AutoSize = true;
            this.lblinfoProfit.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblinfoProfit.Location = new System.Drawing.Point(66, 59);
            this.lblinfoProfit.Name = "lblinfoProfit";
            this.lblinfoProfit.Size = new System.Drawing.Size(42, 26);
            this.lblinfoProfit.TabIndex = 25;
            this.lblinfoProfit.Text = "₪0";
            this.lblinfoProfit.Click += new System.EventHandler(this.lblinfoProfit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "יומי",
            "חודשי",
            "שנתי"});
            this.comboBox1.Location = new System.Drawing.Point(692, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(153, 30);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Text = "יומי";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelCountSale
            // 
            this.panelCountSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelCountSale.Controls.Add(this.lblinfoCount);
            this.panelCountSale.Controls.Add(this.lblCountSales);
            this.panelCountSale.Location = new System.Drawing.Point(867, 581);
            this.panelCountSale.Name = "panelCountSale";
            this.panelCountSale.Size = new System.Drawing.Size(213, 120);
            this.panelCountSale.TabIndex = 27;
            // 
            // panelProfit
            // 
            this.panelProfit.BackColor = System.Drawing.Color.LawnGreen;
            this.panelProfit.Controls.Add(this.lblinfoProfit);
            this.panelProfit.Controls.Add(this.lblProfit);
            this.panelProfit.Location = new System.Drawing.Point(146, 581);
            this.panelProfit.Name = "panelProfit";
            this.panelProfit.Size = new System.Drawing.Size(213, 120);
            this.panelProfit.TabIndex = 28;
            // 
            // panelSale
            // 
            this.panelSale.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelSale.Controls.Add(this.lblinfoSales);
            this.panelSale.Controls.Add(this.lblSales);
            this.panelSale.Location = new System.Drawing.Point(626, 581);
            this.panelSale.Name = "panelSale";
            this.panelSale.Size = new System.Drawing.Size(213, 120);
            this.panelSale.TabIndex = 29;
            // 
            // panelExpo
            // 
            this.panelExpo.BackColor = System.Drawing.Color.Tomato;
            this.panelExpo.Controls.Add(this.lblinfoExpo);
            this.panelExpo.Controls.Add(this.lblExpenses);
            this.panelExpo.Location = new System.Drawing.Point(384, 581);
            this.panelExpo.Name = "panelExpo";
            this.panelExpo.Size = new System.Drawing.Size(213, 120);
            this.panelExpo.TabIndex = 30;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(306, 163);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "תזרים העסק";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(591, 363);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // Statistics_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 781);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panelExpo);
            this.Controls.Add(this.panelSale);
            this.Controls.Add(this.panelProfit);
            this.Controls.Add(this.panelCountSale);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics_Manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics_Manage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Statistics_Manage_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelCountSale.ResumeLayout(false);
            this.panelCountSale.PerformLayout();
            this.panelProfit.ResumeLayout(false);
            this.panelProfit.PerformLayout();
            this.panelSale.ResumeLayout(false);
            this.panelSale.PerformLayout();
            this.panelExpo.ResumeLayout(false);
            this.panelExpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblExpenses;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.Label lblCountSales;
        private System.Windows.Forms.Label lblinfoCount;
        private System.Windows.Forms.Label lblinfoSales;
        private System.Windows.Forms.Label lblinfoExpo;
        private System.Windows.Forms.Label lblinfoProfit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelCountSale;
        private System.Windows.Forms.Panel panelProfit;
        private System.Windows.Forms.Panel panelSale;
        private System.Windows.Forms.Panel panelExpo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}