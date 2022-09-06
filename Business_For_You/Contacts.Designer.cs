
namespace Business_For_You
{
    partial class Contacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacts));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.listBoxSuppliers = new System.Windows.Forms.ListBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 53);
            this.panel2.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl1.Location = new System.Drawing.Point(581, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl1.Size = new System.Drawing.Size(89, 22);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "אנשי קשר";
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 22;
            this.listBoxCustomers.Location = new System.Drawing.Point(730, 128);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxCustomers.Size = new System.Drawing.Size(492, 400);
            this.listBoxCustomers.TabIndex = 10;
            // 
            // listBoxSuppliers
            // 
            this.listBoxSuppliers.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxSuppliers.FormattingEnabled = true;
            this.listBoxSuppliers.ItemHeight = 22;
            this.listBoxSuppliers.Location = new System.Drawing.Point(59, 128);
            this.listBoxSuppliers.Name = "listBoxSuppliers";
            this.listBoxSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxSuppliers.Size = new System.Drawing.Size(492, 400);
            this.listBoxSuppliers.TabIndex = 11;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCustomers.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCustomers.Location = new System.Drawing.Point(1120, 94);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomers.Size = new System.Drawing.Size(65, 22);
            this.lblCustomers.TabIndex = 12;
            this.lblCustomers.Text = "לקוחות";
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSuppliers.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblSuppliers.Location = new System.Drawing.Point(457, 94);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSuppliers.Size = new System.Drawing.Size(61, 22);
            this.lblSuppliers.TabIndex = 13;
            this.lblSuppliers.Text = "ספקים";
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 762);
            this.Controls.Add(this.lblSuppliers);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.listBoxSuppliers);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contacts";
            this.Text = "Contacts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.ListBox listBoxSuppliers;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblSuppliers;
    }
}