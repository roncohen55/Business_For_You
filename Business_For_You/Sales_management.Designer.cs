
namespace Business_For_You
{
    partial class Sales_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_management));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btninformation = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtNameBayer = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnViewSale = new System.Windows.Forms.Button();
            this.btnUpdateSale = new System.Windows.Forms.Button();
            this.txtPriceForMe = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnSaleOfMonth = new System.Windows.Forms.Button();
            this.btnAllSale = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCreatePdf = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(492, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(565, 422);
            this.listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 58);
            this.panel1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(432, 22);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(126, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "מכירות עסק";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblInformation.Location = new System.Drawing.Point(136, 108);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInformation.Size = new System.Drawing.Size(100, 26);
            this.lblInformation.TabIndex = 22;
            this.lblInformation.Text = "פרטי הזמנה";
            // 
            // btninformation
            // 
            this.btninformation.BackColor = System.Drawing.SystemColors.Window;
            this.btninformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btninformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformation.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btninformation.Location = new System.Drawing.Point(810, 562);
            this.btninformation.Name = "btninformation";
            this.btninformation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btninformation.Size = new System.Drawing.Size(144, 30);
            this.btninformation.TabIndex = 23;
            this.btninformation.Text = "הצג פרטים";
            this.btninformation.UseVisualStyleBackColor = false;
            this.btninformation.Click += new System.EventHandler(this.btninformation_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Window;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelete.Location = new System.Drawing.Point(559, 562);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 30);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "הסר עסקה";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtInfo.Location = new System.Drawing.Point(131, 151);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInfo.Size = new System.Drawing.Size(146, 29);
            this.txtInfo.TabIndex = 29;
            this.txtInfo.Text = "פירוט עסקה";
            // 
            // txtNameBayer
            // 
            this.txtNameBayer.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNameBayer.Location = new System.Drawing.Point(131, 214);
            this.txtNameBayer.Name = "txtNameBayer";
            this.txtNameBayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNameBayer.Size = new System.Drawing.Size(146, 29);
            this.txtNameBayer.TabIndex = 32;
            this.txtNameBayer.Text = "שם הקונה";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPhone.Location = new System.Drawing.Point(131, 272);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(146, 29);
            this.txtPhone.TabIndex = 33;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAddress.Location = new System.Drawing.Point(131, 325);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(146, 29);
            this.txtAddress.TabIndex = 34;
            this.txtAddress.Text = "כתובת";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEmail.Location = new System.Drawing.Point(131, 382);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 28);
            this.txtEmail.TabIndex = 35;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNote.Location = new System.Drawing.Point(94, 523);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNote.Size = new System.Drawing.Size(229, 84);
            this.txtNote.TabIndex = 36;
            this.txtNote.Text = "הערות";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.Location = new System.Drawing.Point(131, 624);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(144, 30);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "עדכן ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnViewSale
            // 
            this.btnViewSale.BackColor = System.Drawing.SystemColors.Window;
            this.btnViewSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnViewSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSale.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnViewSale.Location = new System.Drawing.Point(810, 624);
            this.btnViewSale.Name = "btnViewSale";
            this.btnViewSale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnViewSale.Size = new System.Drawing.Size(144, 30);
            this.btnViewSale.TabIndex = 38;
            this.btnViewSale.Text = "צפייה בעיסקה";
            this.btnViewSale.UseVisualStyleBackColor = false;
            this.btnViewSale.Click += new System.EventHandler(this.btnViewSale_Click);
            // 
            // btnUpdateSale
            // 
            this.btnUpdateSale.BackColor = System.Drawing.SystemColors.Window;
            this.btnUpdateSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnUpdateSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSale.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdateSale.Location = new System.Drawing.Point(559, 624);
            this.btnUpdateSale.Name = "btnUpdateSale";
            this.btnUpdateSale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdateSale.Size = new System.Drawing.Size(144, 30);
            this.btnUpdateSale.TabIndex = 39;
            this.btnUpdateSale.Text = "עדכן עיסקה";
            this.btnUpdateSale.UseVisualStyleBackColor = false;
            this.btnUpdateSale.Click += new System.EventHandler(this.btnUpdateSale_Click);
            // 
            // txtPriceForMe
            // 
            this.txtPriceForMe.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPriceForMe.ForeColor = System.Drawing.Color.Red;
            this.txtPriceForMe.Location = new System.Drawing.Point(131, 443);
            this.txtPriceForMe.Name = "txtPriceForMe";
            this.txtPriceForMe.Size = new System.Drawing.Size(146, 29);
            this.txtPriceForMe.TabIndex = 40;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.Location = new System.Drawing.Point(131, 487);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPrice.Size = new System.Drawing.Size(25, 22);
            this.lblPrice.TabIndex = 41;
            this.lblPrice.Text = "₪";
            // 
            // btnSaleOfMonth
            // 
            this.btnSaleOfMonth.BackColor = System.Drawing.SystemColors.Window;
            this.btnSaleOfMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnSaleOfMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleOfMonth.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSaleOfMonth.Location = new System.Drawing.Point(794, 72);
            this.btnSaleOfMonth.Name = "btnSaleOfMonth";
            this.btnSaleOfMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSaleOfMonth.Size = new System.Drawing.Size(121, 30);
            this.btnSaleOfMonth.TabIndex = 42;
            this.btnSaleOfMonth.Text = "מכירות החודש";
            this.btnSaleOfMonth.UseVisualStyleBackColor = false;
            this.btnSaleOfMonth.Click += new System.EventHandler(this.btnSaleOfMonth_Click);
            // 
            // btnAllSale
            // 
            this.btnAllSale.BackColor = System.Drawing.SystemColors.Window;
            this.btnAllSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnAllSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllSale.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAllSale.Location = new System.Drawing.Point(938, 72);
            this.btnAllSale.Name = "btnAllSale";
            this.btnAllSale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAllSale.Size = new System.Drawing.Size(102, 30);
            this.btnAllSale.TabIndex = 43;
            this.btnAllSale.Text = "כל המכירות";
            this.btnAllSale.UseVisualStyleBackColor = false;
            this.btnAllSale.Click += new System.EventHandler(this.btnAllSale_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSearch.Location = new System.Drawing.Point(663, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 29);
            this.txtSearch.TabIndex = 44;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearch.Location = new System.Drawing.Point(547, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 30);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.Text = "חיפוש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCreatePdf
            // 
            this.btnCreatePdf.BackColor = System.Drawing.SystemColors.Window;
            this.btnCreatePdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnCreatePdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePdf.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCreatePdf.Location = new System.Drawing.Point(810, 690);
            this.btnCreatePdf.Name = "btnCreatePdf";
            this.btnCreatePdf.Size = new System.Drawing.Size(144, 30);
            this.btnCreatePdf.TabIndex = 49;
            this.btnCreatePdf.Text = "יצירת קובץ";
            this.btnCreatePdf.UseVisualStyleBackColor = false;
            this.btnCreatePdf.Click += new System.EventHandler(this.btnCreatePdf_Click);
            // 
            // Sales_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 759);
            this.Controls.Add(this.btnCreatePdf);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAllSale);
            this.Controls.Add(this.btnSaleOfMonth);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPriceForMe);
            this.Controls.Add(this.btnUpdateSale);
            this.Controls.Add(this.btnViewSale);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtNameBayer);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btninformation);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales_management";
            this.Text = "Sales_management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sales_management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btninformation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtNameBayer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnViewSale;
        private System.Windows.Forms.Button btnUpdateSale;
        private System.Windows.Forms.TextBox txtPriceForMe;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnSaleOfMonth;
        private System.Windows.Forms.Button btnAllSale;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCreatePdf;
    }
}