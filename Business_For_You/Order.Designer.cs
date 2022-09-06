
namespace Business_For_You
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.label1 = new System.Windows.Forms.Label();
            this.btnmazoman = new System.Windows.Forms.Button();
            this.txtNamebayer = new System.Windows.Forms.TextBox();
            this.txtNumberphone = new System.Windows.Forms.TextBox();
            this.txtAdrress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblasrai = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBoxCustomers = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(509, 120);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnmazoman
            // 
            this.btnmazoman.BackColor = System.Drawing.SystemColors.Window;
            this.btnmazoman.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnmazoman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmazoman.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnmazoman.Location = new System.Drawing.Point(69, 474);
            this.btnmazoman.Name = "btnmazoman";
            this.btnmazoman.Size = new System.Drawing.Size(75, 30);
            this.btnmazoman.TabIndex = 1;
            this.btnmazoman.Text = "תשלום";
            this.btnmazoman.UseVisualStyleBackColor = false;
            this.btnmazoman.Click += new System.EventHandler(this.btnmazoman_Click);
            // 
            // txtNamebayer
            // 
            this.txtNamebayer.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNamebayer.Location = new System.Drawing.Point(55, 117);
            this.txtNamebayer.Name = "txtNamebayer";
            this.txtNamebayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNamebayer.Size = new System.Drawing.Size(146, 29);
            this.txtNamebayer.TabIndex = 2;
            // 
            // txtNumberphone
            // 
            this.txtNumberphone.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNumberphone.Location = new System.Drawing.Point(55, 189);
            this.txtNumberphone.Name = "txtNumberphone";
            this.txtNumberphone.Size = new System.Drawing.Size(146, 29);
            this.txtNumberphone.TabIndex = 3;
            // 
            // txtAdrress
            // 
            this.txtAdrress.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtAdrress.Location = new System.Drawing.Point(55, 252);
            this.txtAdrress.Name = "txtAdrress";
            this.txtAdrress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAdrress.Size = new System.Drawing.Size(146, 29);
            this.txtAdrress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(231, 119);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(102, 220);
            this.label2.TabIndex = 6;
            this.label2.Text = "שם הקונה:\r\n\r\n\r\nמספר פאלפון:\r\n\r\n\r\nכתובת:\r\n\r\n\r\nמייל:";
            // 
            // lblasrai
            // 
            this.lblasrai.AutoSize = true;
            this.lblasrai.Location = new System.Drawing.Point(271, 205);
            this.lblasrai.Name = "lblasrai";
            this.lblasrai.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblasrai.Size = new System.Drawing.Size(0, 13);
            this.lblasrai.TabIndex = 10;
            this.lblasrai.Visible = false;
            // 
            // txtNote
            // 
            this.txtNote.AllowDrop = true;
            this.txtNote.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtNote.Location = new System.Drawing.Point(55, 371);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNote.Size = new System.Drawing.Size(255, 75);
            this.txtNote.TabIndex = 11;
            this.txtNote.Text = "הערות";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEmail.Location = new System.Drawing.Point(55, 310);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(146, 28);
            this.txtEmail.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 50);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(267, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "פרטי לקוח וסיום תהליך הזמנה";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Window;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExit.Location = new System.Drawing.Point(194, 474);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 30);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "חזרה לעריכת הזמנה";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBoxCustomers
            // 
            this.comboBoxCustomers.Font = new System.Drawing.Font("Alef", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxCustomers.FormattingEnabled = true;
            this.comboBoxCustomers.Location = new System.Drawing.Point(80, 72);
            this.comboBoxCustomers.Name = "comboBoxCustomers";
            this.comboBoxCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxCustomers.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCustomers.TabIndex = 17;
            this.comboBoxCustomers.Text = "חיפוש לקוח";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Alef", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSearch.Location = new System.Drawing.Point(12, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "חיפוש";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 534);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxCustomers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lblasrai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdrress);
            this.Controls.Add(this.txtNumberphone);
            this.Controls.Add(this.txtNamebayer);
            this.Controls.Add(this.btnmazoman);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmazoman;
        private System.Windows.Forms.TextBox txtNamebayer;
        private System.Windows.Forms.TextBox txtNumberphone;
        private System.Windows.Forms.TextBox txtAdrress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblasrai;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCustomers;
        private System.Windows.Forms.Button btnSearch;
    }
}