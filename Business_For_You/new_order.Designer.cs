
namespace Business_For_You
{
    partial class new_order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_order));
            this.label1 = new System.Windows.Forms.Label();
            this.listboxProduct = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtMakat = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnInsertToclass = new System.Windows.Forms.Button();
            this.listboxNeworder = new System.Windows.Forms.ListBox();
            this.lblpriceafter = new System.Windows.Forms.Label();
            this.txtpricelifnimam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBid = new System.Windows.Forms.Button();
            this.btnpayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.checkBoxProductClali = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAllProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(704, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 260);
            this.label1.TabIndex = 0;
            this.label1.Text = "מק\"ט\r\n\r\n\r\nשם מוצר\r\n\r\n\r\nכמות\r\n\r\n\r\nמחיר";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listboxProduct
            // 
            this.listboxProduct.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listboxProduct.FormattingEnabled = true;
            this.listboxProduct.ItemHeight = 22;
            this.listboxProduct.Location = new System.Drawing.Point(829, 203);
            this.listboxProduct.Name = "listboxProduct";
            this.listboxProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listboxProduct.Size = new System.Drawing.Size(514, 378);
            this.listboxProduct.TabIndex = 2;
            this.listboxProduct.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.Location = new System.Drawing.Point(995, 616);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "הוסף";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNameProduct.Location = new System.Drawing.Point(542, 288);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNameProduct.Size = new System.Drawing.Size(119, 29);
            this.txtNameProduct.TabIndex = 4;
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtquantity.Location = new System.Drawing.Point(542, 366);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtquantity.Size = new System.Drawing.Size(119, 29);
            this.txtquantity.TabIndex = 5;
            this.txtquantity.Text = "1";
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // txtMakat
            // 
            this.txtMakat.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMakat.Location = new System.Drawing.Point(542, 211);
            this.txtMakat.Name = "txtMakat";
            this.txtMakat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMakat.Size = new System.Drawing.Size(119, 29);
            this.txtMakat.TabIndex = 6;
            this.txtMakat.TextChanged += new System.EventHandler(this.txtMakat_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtPrice.Location = new System.Drawing.Point(542, 439);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(119, 29);
            this.txtPrice.TabIndex = 7;
            // 
            // btnInsertToclass
            // 
            this.btnInsertToclass.BackColor = System.Drawing.SystemColors.Window;
            this.btnInsertToclass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnInsertToclass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertToclass.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnInsertToclass.Location = new System.Drawing.Point(551, 513);
            this.btnInsertToclass.Name = "btnInsertToclass";
            this.btnInsertToclass.Size = new System.Drawing.Size(151, 30);
            this.btnInsertToclass.TabIndex = 8;
            this.btnInsertToclass.Text = "הוסף להזמנה חדשה";
            this.btnInsertToclass.UseVisualStyleBackColor = false;
            this.btnInsertToclass.Click += new System.EventHandler(this.btnInsertToclass_Click);
            // 
            // listboxNeworder
            // 
            this.listboxNeworder.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listboxNeworder.FormattingEnabled = true;
            this.listboxNeworder.ItemHeight = 26;
            this.listboxNeworder.Location = new System.Drawing.Point(42, 203);
            this.listboxNeworder.Name = "listboxNeworder";
            this.listboxNeworder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listboxNeworder.Size = new System.Drawing.Size(463, 394);
            this.listboxNeworder.TabIndex = 9;
            // 
            // lblpriceafter
            // 
            this.lblpriceafter.AutoSize = true;
            this.lblpriceafter.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblpriceafter.Location = new System.Drawing.Point(88, 700);
            this.lblpriceafter.Name = "lblpriceafter";
            this.lblpriceafter.Size = new System.Drawing.Size(24, 26);
            this.lblpriceafter.TabIndex = 10;
            this.lblpriceafter.Text = "0";
            this.lblpriceafter.Click += new System.EventHandler(this.lblpriceafter_Click);
            // 
            // txtpricelifnimam
            // 
            this.txtpricelifnimam.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtpricelifnimam.Location = new System.Drawing.Point(233, 697);
            this.txtpricelifnimam.Name = "txtpricelifnimam";
            this.txtpricelifnimam.Size = new System.Drawing.Size(100, 29);
            this.txtpricelifnimam.TabIndex = 11;
            this.txtpricelifnimam.Text = "0";
            this.txtpricelifnimam.TextChanged += new System.EventHandler(this.txtpricelifnimam_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(351, 697);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "מחיר לפני מעמ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Window;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelete.Location = new System.Drawing.Point(320, 621);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 30);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "הסר מהזמנה ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBid
            // 
            this.btnBid.BackColor = System.Drawing.SystemColors.Window;
            this.btnBid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnBid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBid.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBid.Location = new System.Drawing.Point(199, 621);
            this.btnBid.Name = "btnBid";
            this.btnBid.Size = new System.Drawing.Size(97, 30);
            this.btnBid.TabIndex = 14;
            this.btnBid.Text = "הצעת מחיר";
            this.btnBid.UseVisualStyleBackColor = false;
            this.btnBid.Click += new System.EventHandler(this.btnBid_Click);
            // 
            // btnpayment
            // 
            this.btnpayment.BackColor = System.Drawing.SystemColors.Window;
            this.btnpayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpayment.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnpayment.Location = new System.Drawing.Point(75, 621);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(93, 30);
            this.btnpayment.TabIndex = 15;
            this.btnpayment.Text = "לרכישה";
            this.btnpayment.UseVisualStyleBackColor = false;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(205, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "מק\"ט      שם מוצר      כמות      מחיר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(1043, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "מק\"ט      שם מוצר      כמות      מחיר";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1399, 58);
            this.panel1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(522, 10);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(133, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "הזמנה חדשה";
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
            // checkBoxProductClali
            // 
            this.checkBoxProductClali.AutoSize = true;
            this.checkBoxProductClali.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxProductClali.Location = new System.Drawing.Point(564, 162);
            this.checkBoxProductClali.Name = "checkBoxProductClali";
            this.checkBoxProductClali.Size = new System.Drawing.Size(97, 26);
            this.checkBoxProductClali.TabIndex = 20;
            this.checkBoxProductClali.Text = "מוצר כללי";
            this.checkBoxProductClali.UseVisualStyleBackColor = true;
            this.checkBoxProductClali.CheckedChanged += new System.EventHandler(this.checkBoxProductClali_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearch.Location = new System.Drawing.Point(829, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "חיפוש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSearch.Location = new System.Drawing.Point(921, 168);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(100, 29);
            this.txtSearch.TabIndex = 23;
            // 
            // btnAllProduct
            // 
            this.btnAllProduct.BackColor = System.Drawing.SystemColors.Window;
            this.btnAllProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllProduct.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAllProduct.Location = new System.Drawing.Point(1120, 616);
            this.btnAllProduct.Name = "btnAllProduct";
            this.btnAllProduct.Size = new System.Drawing.Size(153, 30);
            this.btnAllProduct.TabIndex = 24;
            this.btnAllProduct.Text = "הצג את כל המוצרים";
            this.btnAllProduct.UseVisualStyleBackColor = false;
            this.btnAllProduct.Click += new System.EventHandler(this.btnAllProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(42, 705);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "₪";
            // 
            // new_order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1399, 814);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAllProduct);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.checkBoxProductClali);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnpayment);
            this.Controls.Add(this.btnBid);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpricelifnimam);
            this.Controls.Add(this.lblpriceafter);
            this.Controls.Add(this.listboxNeworder);
            this.Controls.Add(this.btnInsertToclass);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMakat);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listboxProduct);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "new_order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "new_order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.new_order_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listboxProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtMakat;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnInsertToclass;
        private System.Windows.Forms.ListBox listboxNeworder;
        private System.Windows.Forms.Label lblpriceafter;
        private System.Windows.Forms.TextBox txtpricelifnimam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBid;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxProductClali;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAllProduct;
        private System.Windows.Forms.Label label6;
    }
}