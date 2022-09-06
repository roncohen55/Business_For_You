
namespace Business_For_You
{
    partial class Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.btninformation = new System.Windows.Forms.Button();
            this.btnDeleteSuppliers = new System.Windows.Forms.Button();
            this.btnViewSuppliers = new System.Windows.Forms.Button();
            this.btnUpdateSuppliers = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(471, 24);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(129, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "ניהול ספקים";
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
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(495, 125);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBox1.Size = new System.Drawing.Size(550, 312);
            this.listBox1.TabIndex = 25;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblInformation.Location = new System.Drawing.Point(107, 94);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInformation.Size = new System.Drawing.Size(106, 26);
            this.lblInformation.TabIndex = 26;
            this.lblInformation.Text = "פרטי ההספק";
            // 
            // btninformation
            // 
            this.btninformation.BackColor = System.Drawing.SystemColors.Window;
            this.btninformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btninformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformation.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btninformation.Location = new System.Drawing.Point(816, 456);
            this.btninformation.Name = "btninformation";
            this.btninformation.Size = new System.Drawing.Size(144, 30);
            this.btninformation.TabIndex = 27;
            this.btninformation.Text = "הצג פרטים";
            this.btninformation.UseVisualStyleBackColor = false;
            this.btninformation.Click += new System.EventHandler(this.btninformation_Click);
            // 
            // btnDeleteSuppliers
            // 
            this.btnDeleteSuppliers.BackColor = System.Drawing.SystemColors.Window;
            this.btnDeleteSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnDeleteSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSuppliers.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDeleteSuppliers.Location = new System.Drawing.Point(621, 521);
            this.btnDeleteSuppliers.Name = "btnDeleteSuppliers";
            this.btnDeleteSuppliers.Size = new System.Drawing.Size(144, 30);
            this.btnDeleteSuppliers.TabIndex = 28;
            this.btnDeleteSuppliers.Text = "מחק ספק";
            this.btnDeleteSuppliers.UseVisualStyleBackColor = false;
            this.btnDeleteSuppliers.Click += new System.EventHandler(this.btnDeleteSuppliers_Click);
            // 
            // btnViewSuppliers
            // 
            this.btnViewSuppliers.BackColor = System.Drawing.SystemColors.Window;
            this.btnViewSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnViewSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSuppliers.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnViewSuppliers.Location = new System.Drawing.Point(816, 521);
            this.btnViewSuppliers.Name = "btnViewSuppliers";
            this.btnViewSuppliers.Size = new System.Drawing.Size(144, 30);
            this.btnViewSuppliers.TabIndex = 29;
            this.btnViewSuppliers.Text = "צפה בספק";
            this.btnViewSuppliers.UseVisualStyleBackColor = false;
            this.btnViewSuppliers.Click += new System.EventHandler(this.btnViewSuppliers_Click);
            // 
            // btnUpdateSuppliers
            // 
            this.btnUpdateSuppliers.BackColor = System.Drawing.SystemColors.Window;
            this.btnUpdateSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnUpdateSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSuppliers.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdateSuppliers.Location = new System.Drawing.Point(621, 456);
            this.btnUpdateSuppliers.Name = "btnUpdateSuppliers";
            this.btnUpdateSuppliers.Size = new System.Drawing.Size(144, 30);
            this.btnUpdateSuppliers.TabIndex = 30;
            this.btnUpdateSuppliers.Text = "עדכן ספק";
            this.btnUpdateSuppliers.UseVisualStyleBackColor = false;
            this.btnUpdateSuppliers.Click += new System.EventHandler(this.btnUpdateSuppliers_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtName.Location = new System.Drawing.Point(107, 147);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(146, 29);
            this.txtName.TabIndex = 31;
            // 
            // txtCompany
            // 
            this.txtCompany.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtCompany.Location = new System.Drawing.Point(107, 194);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCompany.Size = new System.Drawing.Size(146, 29);
            this.txtCompany.TabIndex = 32;
            // 
            // txtRating
            // 
            this.txtRating.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtRating.Location = new System.Drawing.Point(107, 349);
            this.txtRating.Name = "txtRating";
            this.txtRating.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRating.Size = new System.Drawing.Size(146, 29);
            this.txtRating.TabIndex = 33;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPhone.Location = new System.Drawing.Point(107, 247);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(146, 29);
            this.txtPhone.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEmail.Location = new System.Drawing.Point(107, 300);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmail.Size = new System.Drawing.Size(146, 28);
            this.txtEmail.TabIndex = 35;
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDetails.Location = new System.Drawing.Point(82, 397);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetails.Size = new System.Drawing.Size(189, 65);
            this.txtDetails.TabIndex = 36;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.Location = new System.Drawing.Point(107, 483);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdate.Size = new System.Drawing.Size(144, 30);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "עדכן ";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.SystemColors.Window;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnInsert.Location = new System.Drawing.Point(107, 543);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInsert.Size = new System.Drawing.Size(144, 30);
            this.btnInsert.TabIndex = 38;
            this.btnInsert.Text = "הכנס ספק חדש ";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(912, 94);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "מספר  שם  חברה  ";
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1118, 724);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnUpdateSuppliers);
            this.Controls.Add(this.btnViewSuppliers);
            this.Controls.Add(this.btnDeleteSuppliers);
            this.Controls.Add(this.btninformation);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Button btninformation;
        private System.Windows.Forms.Button btnDeleteSuppliers;
        private System.Windows.Forms.Button btnViewSuppliers;
        private System.Windows.Forms.Button btnUpdateSuppliers;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
    }
}