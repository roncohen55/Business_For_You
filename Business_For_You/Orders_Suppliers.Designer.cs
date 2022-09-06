
namespace Business_For_You
{
    partial class Orders_Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders_Suppliers));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMakat = new System.Windows.Forms.Label();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.lblPriceForMe = new System.Windows.Forms.Label();
            this.lblQuntity = new System.Windows.Forms.Label();
            this.txtNewCamot = new System.Windows.Forms.TextBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.listBoxNewOrder = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxSuppliers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPriceOrder = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.lblOrderFrom = new System.Windows.Forms.Label();
            this.btnSearchSuppliers = new System.Windows.Forms.Button();
            this.lblNameSuppliers = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
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
            this.panel4.Size = new System.Drawing.Size(1240, 47);
            this.panel4.TabIndex = 17;
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
            this.label3.Size = new System.Drawing.Size(181, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "הזמנה חדשה מספק";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(381, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "מק\"ט                 שם מוצר             מחיר עלות                 כמות להזמנה   " +
    "         כמות נוכחית";
            // 
            // lblMakat
            // 
            this.lblMakat.AutoSize = true;
            this.lblMakat.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMakat.Location = new System.Drawing.Point(936, 113);
            this.lblMakat.Name = "lblMakat";
            this.lblMakat.Size = new System.Drawing.Size(18, 20);
            this.lblMakat.TabIndex = 19;
            this.lblMakat.Text = "0";
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNameProduct.Location = new System.Drawing.Point(821, 113);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(18, 20);
            this.lblNameProduct.TabIndex = 20;
            this.lblNameProduct.Text = "0";
            // 
            // lblPriceForMe
            // 
            this.lblPriceForMe.AutoSize = true;
            this.lblPriceForMe.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPriceForMe.Location = new System.Drawing.Point(707, 113);
            this.lblPriceForMe.Name = "lblPriceForMe";
            this.lblPriceForMe.Size = new System.Drawing.Size(18, 20);
            this.lblPriceForMe.TabIndex = 21;
            this.lblPriceForMe.Text = "0";
            // 
            // lblQuntity
            // 
            this.lblQuntity.AutoSize = true;
            this.lblQuntity.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblQuntity.Location = new System.Drawing.Point(412, 113);
            this.lblQuntity.Name = "lblQuntity";
            this.lblQuntity.Size = new System.Drawing.Size(18, 20);
            this.lblQuntity.TabIndex = 22;
            this.lblQuntity.Text = "0";
            // 
            // txtNewCamot
            // 
            this.txtNewCamot.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNewCamot.Location = new System.Drawing.Point(510, 110);
            this.txtNewCamot.Name = "txtNewCamot";
            this.txtNewCamot.Size = new System.Drawing.Size(100, 28);
            this.txtNewCamot.TabIndex = 23;
            this.txtNewCamot.Text = "0";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(1094, 78);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxProduct.Size = new System.Drawing.Size(121, 30);
            this.comboBoxProduct.TabIndex = 24;
            this.comboBoxProduct.Text = "בחר מוצר";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearchProduct.Location = new System.Drawing.Point(998, 76);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(75, 32);
            this.btnSearchProduct.TabIndex = 25;
            this.btnSearchProduct.Text = "חיפוש";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // listBoxNewOrder
            // 
            this.listBoxNewOrder.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxNewOrder.FormattingEnabled = true;
            this.listBoxNewOrder.ItemHeight = 22;
            this.listBoxNewOrder.Location = new System.Drawing.Point(227, 219);
            this.listBoxNewOrder.Name = "listBoxNewOrder";
            this.listBoxNewOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxNewOrder.Size = new System.Drawing.Size(785, 422);
            this.listBoxNewOrder.TabIndex = 26;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.Location = new System.Drawing.Point(241, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 28);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "הוסף מוצר";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxSuppliers
            // 
            this.comboBoxSuppliers.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxSuppliers.FormattingEnabled = true;
            this.comboBoxSuppliers.Location = new System.Drawing.Point(581, 183);
            this.comboBoxSuppliers.Name = "comboBoxSuppliers";
            this.comboBoxSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxSuppliers.Size = new System.Drawing.Size(121, 30);
            this.comboBoxSuppliers.TabIndex = 28;
            this.comboBoxSuppliers.Text = "בחר ספק";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(732, 187);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "בחר ספק:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Window;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelete.Location = new System.Drawing.Point(825, 659);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 28);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "מחק מוצר";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(257, 693);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "מחיר:";
            // 
            // lblPriceOrder
            // 
            this.lblPriceOrder.AutoSize = true;
            this.lblPriceOrder.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPriceOrder.Location = new System.Drawing.Point(223, 693);
            this.lblPriceOrder.Name = "lblPriceOrder";
            this.lblPriceOrder.Size = new System.Drawing.Size(18, 20);
            this.lblPriceOrder.TabIndex = 32;
            this.lblPriceOrder.Text = "0";
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.SystemColors.Window;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPayment.Location = new System.Drawing.Point(68, 687);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(93, 28);
            this.btnPayment.TabIndex = 33;
            this.btnPayment.Text = "תשלום";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblOrderFrom
            // 
            this.lblOrderFrom.AutoSize = true;
            this.lblOrderFrom.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblOrderFrom.Location = new System.Drawing.Point(314, 186);
            this.lblOrderFrom.Name = "lblOrderFrom";
            this.lblOrderFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOrderFrom.Size = new System.Drawing.Size(70, 22);
            this.lblOrderFrom.TabIndex = 34;
            this.lblOrderFrom.Text = "הזמנה מ:";
            // 
            // btnSearchSuppliers
            // 
            this.btnSearchSuppliers.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearchSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSuppliers.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearchSuppliers.Location = new System.Drawing.Point(488, 183);
            this.btnSearchSuppliers.Name = "btnSearchSuppliers";
            this.btnSearchSuppliers.Size = new System.Drawing.Size(75, 32);
            this.btnSearchSuppliers.TabIndex = 35;
            this.btnSearchSuppliers.Text = "חיפוש";
            this.btnSearchSuppliers.UseVisualStyleBackColor = false;
            this.btnSearchSuppliers.Click += new System.EventHandler(this.btnSearchSuppliers_Click);
            // 
            // lblNameSuppliers
            // 
            this.lblNameSuppliers.AutoSize = true;
            this.lblNameSuppliers.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblNameSuppliers.Location = new System.Drawing.Point(175, 186);
            this.lblNameSuppliers.Name = "lblNameSuppliers";
            this.lblNameSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNameSuppliers.Size = new System.Drawing.Size(0, 22);
            this.lblNameSuppliers.TabIndex = 36;
            // 
            // Orders_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 778);
            this.Controls.Add(this.lblNameSuppliers);
            this.Controls.Add(this.btnSearchSuppliers);
            this.Controls.Add(this.lblOrderFrom);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.lblPriceOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSuppliers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxNewOrder);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.txtNewCamot);
            this.Controls.Add(this.lblQuntity);
            this.Controls.Add(this.lblPriceForMe);
            this.Controls.Add(this.lblNameProduct);
            this.Controls.Add(this.lblMakat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders_Suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders_Suppliers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Orders_Suppliers_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMakat;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label lblPriceForMe;
        private System.Windows.Forms.Label lblQuntity;
        private System.Windows.Forms.TextBox txtNewCamot;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.ListBox listBoxNewOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxSuppliers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPriceOrder;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblOrderFrom;
        private System.Windows.Forms.Button btnSearchSuppliers;
        private System.Windows.Forms.Label lblNameSuppliers;
    }
}