using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_For_You
{
    public partial class Suppliers : Form
    {
        private Suppliers_Class tmp = new Suppliers_Class();

        private Suppliers_Class _suppliersInfo;

        public Suppliers()
        {
            InitializeComponent();
            ShowSuppliers();
            LabelOnAndTxtOff();
        }

        private void ShowSuppliers()
        {
            try
            {
                listBox1.Items.Clear();
                List<string> tmp1 = new List<string>();
                tmp1 = tmp.ShowList();
                for (int i = 0; i < tmp1.Count; i++)
                    listBox1.Items.Add(tmp1[i]);

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //show all data from one Suppliers
        private void ShowinfoFromdata()
        {
            try
            {
                _suppliersInfo = tmp.ShowinfoFromdata(listBox1.Text);

                string str = "";

                str = "פרטי ספק" + "\n" + "מספר ספק" + " " + _suppliersInfo.getId().ToString() + "\n" + "שם ספק" + " " + _suppliersInfo.getName() + "\n" + "חברה" + " " + _suppliersInfo.getCompany() + "\n" + "פירוט על הספק" + " " + _suppliersInfo.getDetails().ToString() + "\n" + "מספר פאלפון" + " " + _suppliersInfo.getPhone() + "\n" + "אימייל" + " " + _suppliersInfo.getEmail() + "\n" + "דירוג" + " " + _suppliersInfo.getRating().ToString();

                lblInformation.Text = str;

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowinfoFromdataTotxt()
        {
            try
            {
                _suppliersInfo = tmp.ShowinfoFromdata(listBox1.Text);
                txtCompany.Text = _suppliersInfo.getCompany();
                txtEmail.Text = _suppliersInfo.getEmail();
                txtName.Text = _suppliersInfo.getName();
                txtDetails.Text = _suppliersInfo.getDetails();
                txtRating.Text = _suppliersInfo.getRating().ToString();
                txtPhone.Text = _suppliersInfo.getPhone();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete one Suppliers
        private void DeleteSuppliers()
        {
            try
            {
                tmp.Delete(listBox1.Text);
                MessageBox.Show("Delete Sucsses");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSuppliers()
        {


            try
            {

                tmp.UpdateSuppliers(txtName.Text,txtCompany.Text, txtDetails.Text, txtPhone.Text, txtEmail.Text,int.Parse( txtRating.Text) , _suppliersInfo.getId());
                MessageBox.Show("Update  Row");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertNewSuppliers()
        {
            try
            {

                tmp.insertNewSuppliers(txtName.Text, txtCompany.Text, txtDetails.Text, txtPhone.Text, txtEmail.Text, int.Parse(txtRating.Text));
                MessageBox.Show("Insert Row");
             

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LabelOnAndTxtOff()
        {
            lblInformation.Visible = true;
            txtCompany.Visible = false;
            txtEmail.Visible = false;
            txtName.Visible = false;
            txtDetails.Visible = false;
            txtRating.Visible = false;
            txtPhone.Visible = false;
            btnUpdate.Visible = false;
            btnInsert.Visible = false;
        }

        private void TxtOnAndLabelOff()
        {
            lblInformation.Visible = false;
            txtCompany.Visible = true;
            txtEmail.Visible = true;
            txtName.Visible = true;
            txtDetails.Visible = true;
            txtRating.Visible = true;
            txtPhone.Visible = true;
            btnUpdate.Visible = true;
            btnInsert.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninformation_Click(object sender, EventArgs e)
        {
            if (lblInformation.Visible == true)
                ShowinfoFromdata();
            else
                ShowinfoFromdataTotxt(); 
        }

        private void btnUpdateSuppliers_Click(object sender, EventArgs e)
        {
            TxtOnAndLabelOff();
        }

        private void btnViewSuppliers_Click(object sender, EventArgs e)
        {
            LabelOnAndTxtOff();
        }

        private void btnDeleteSuppliers_Click(object sender, EventArgs e)
        {
            DeleteSuppliers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateSuppliers();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            insertNewSuppliers();
        }
    }
}
