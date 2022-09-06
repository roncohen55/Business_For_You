using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Business_For_You
{
    public partial class SendEmail : Form
    {
        private List<Sales_class> _listSale = new List<Sales_class>();

        private List<Sales_class> _tmplistCustomers2 = new List<Sales_class>();

        private Sales_class tmp = new Sales_class();

        private Sales_class _SaleInfo11 = new Sales_class();

        private Suppliers_Class tmpSuppliers = new Suppliers_Class();

        private List<Suppliers_Class> _listObjectSuppliers = new List<Suppliers_Class>();

        private Suppliers_Class _SupplierInfo = new Suppliers_Class();

        public SendEmail()
        {
            InitializeComponent();
            _listSale.Clear();
            _listSale = tmp.ShowListObject();
            ShowCustomers();
            ShowSuppliers();
        }

        private void ganerateCustomersForList(Sales_class Customers)
        {

            int i, c = 0;

            for (i = 0; i < _tmplistCustomers2.Count; i++)
            {
                if (_tmplistCustomers2[i].getName() == Customers.getName() && _tmplistCustomers2[i].getPhone() == Customers.getPhone() && _tmplistCustomers2[i].getEmail() == Customers.getEmail())
                    c++;
            }
            if (c == 0)
                _tmplistCustomers2.Add(Customers);


        }



        private void ShowCustomers()
        {
            try
            {
                comboBoxCustomers.Items.Clear();


                _tmplistCustomers2.Clear();



                for (int j = 0; j < _listSale.Count; j++)
                {
                    ganerateCustomersForList(_listSale[j]);
                }


                for (int i = 0; i < _tmplistCustomers2.Count; i++)
                {
                    string str = _tmplistCustomers2[i].getId() + " " + _tmplistCustomers2[i].getName();
                    comboBoxCustomers.Items.Add(str);
                }


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //func to search custumers
        public void SearchCustomers(string str)
        {
            int id = 0, c = 0, cBodak = 0;
            string strId = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    c++;
                if (c == 0 && str[i] >= '0' && str[i] <= '9')
                    strId += str[i];
            }

            if (strId == "")
                MessageBox.Show("לא נמצא לקוח", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                id = int.Parse(strId);

                for (int j = 0; j < _tmplistCustomers2.Count; j++)
                {
                    if (id == _tmplistCustomers2[j].getId())
                    {
                        _SaleInfo11 = _tmplistCustomers2[j];
                        cBodak++;
                    }

                }

                if (cBodak > 0)
                {              
                    txtSendTo.Text = _SaleInfo11.getEmail();
                }

                else
                    MessageBox.Show("לא נמצא לקוח", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ShowSuppliers()
        {
            try
            {
                _listObjectSuppliers.Clear();
                comboBoxSuppliers.Items.Clear();

                _listObjectSuppliers = tmpSuppliers.ShowListObject();
                for (int i = 0; i < _listObjectSuppliers.Count; i++)
                {
                    string str = _listObjectSuppliers[i].getId() + " " + _listObjectSuppliers[i].getName();
                    comboBoxSuppliers.Items.Add(str);
                }


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //func to search suppliers
        public void SearchSuppliers(string str)
        {
            int id = 0, c = 0, cBodak = 0;
            string strId = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    c++;
                if (c == 0 && str[i] >= '0' && str[i] <= '9')
                    strId += str[i];
            }

            if (strId == "")
                MessageBox.Show("לא נמצא ספק", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                id = int.Parse(strId);

                for (int j = 0; j < _listObjectSuppliers.Count; j++)
                {
                    if (id == _listObjectSuppliers[j].getId())
                    {
                        _SupplierInfo = _listObjectSuppliers[j];
                        cBodak++;
                    }

                }

                if (cBodak > 0)
                {
                    txtSendTo.Text = _SupplierInfo.getEmail();
                }

                else
                    MessageBox.Show("לא נמצא ספק", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool checkEmail(string str)
        {
            int cNakoda = 0, c1 = 0;
            if (str == "" || txtBody.Text == "")
                return false;
            else
            {
                for(int i=0; i < str.Length; i++)
                {
                    if (i == 0 && str[i] == '@')
                        return false;
                    if (str[i] == '@')
                        c1++;
                    if (str[i] == '.')
                        cNakoda++;
                    if (cNakoda > 1 || c1 > 1 || cNakoda > 1 && c1 > 1)
                        return false;
                }
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (checkEmail(txtSendTo.Text) == true)
            {
                try
                {

                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress("businessforyou1212@gmail.com");
                    msg.To.Add(txtSendTo.Text);
                    msg.Subject = txtSubject.Text;
                    msg.Body = txtBody.Text;

                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = "businessforyou1212@gmail.com";
                    ntcd.Password = "nofhssyjuvzsehek";
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);

                    MessageBox.Show("Your Mail is sended");

                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
            else
                MessageBox.Show("הנתונים שהוזנו שגואים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCustomers(comboBoxCustomers.Text);
        }

        private void btnSearchSuppliers_Click(object sender, EventArgs e)
        {
            SearchSuppliers(comboBoxSuppliers.Text);
        }
    }
}
