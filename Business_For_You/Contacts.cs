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
    public partial class Contacts : Form
    {
        private Sales_class tmp = new Sales_class();
        
        private List<Sales_class> _tmplistCustomers = new List<Sales_class>();

        private List<Sales_class> _tmplistCustomers2 = new List<Sales_class>();

        private Suppliers_Class tmpSuppliers = new Suppliers_Class();

        private List<Suppliers_Class> _listObjectSuppliers = new List<Suppliers_Class>();

        

        public Contacts()
        {
            InitializeComponent();
            ShowCustomers();
            ShowSuppliers();
        }

        private void ganerateCustomersForList(Sales_class Customers)
        {

             int i, c = 0;

             for (i = 0; i < _tmplistCustomers2.Count; i++)
             {
                 if (_tmplistCustomers2[i].getName() == Customers.getName() &&  _tmplistCustomers2[i].getPhone() == Customers.getPhone() && _tmplistCustomers2[i].getEmail() == Customers.getEmail())
                     c++;
             }
             if (c == 0)
                 _tmplistCustomers2.Add(Customers);


        }



        private void ShowCustomers()
        {
            try
            {
                listBoxCustomers.Items.Clear();

                _tmplistCustomers.Clear();
                _tmplistCustomers2.Clear();

                _tmplistCustomers = tmp.ShowListObject();

                for(int j = 0; j < _tmplistCustomers.Count; j++)
                {
                    ganerateCustomersForList(_tmplistCustomers[j]);
                }


                for(int i = 0; i < _tmplistCustomers2.Count; i++)
                {
                    string str = _tmplistCustomers2[i].getId() + " " + _tmplistCustomers2[i].getName() + " " + _tmplistCustomers2[i].getPhone() + " " + _tmplistCustomers2[i].getAddress() + " " + _tmplistCustomers2[i].getEmail();
                    listBoxCustomers.Items.Add(str);
                }
              

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowSuppliers()
        {
            try
            {
                _listObjectSuppliers.Clear();
                listBoxSuppliers.Items.Clear();
                
                _listObjectSuppliers = tmpSuppliers.ShowListObject();
                for (int i = 0; i < _listObjectSuppliers.Count; i++)
                {
                    string str = _listObjectSuppliers[i].getId() + " " + _listObjectSuppliers[i].getName() + " " + _listObjectSuppliers[i].getCompany() + " " + _listObjectSuppliers[i].getEmail() + " " + _listObjectSuppliers[i].getPhone();
                    listBoxSuppliers.Items.Add(str);
                }
                    

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
