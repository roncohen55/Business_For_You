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
    public partial class Dashboard_Manager : Form
    {
        private Statistics_info StaticInfoDay;

        private Statistics_info StaticInfoMonth;

        private string _NameUser;

        private Statistics_info tmp = new Statistics_info();

        public Dashboard_Manager(string nameus)
        {
            InitializeComponent();
            lblwellcome.Text = "נהל את העסק שלך"+" " + nameus;
            _NameUser = nameus;
            infoForLblDayAndMonth();
        }

        private void infoForLblDayAndMonth()
        {
            try
            {
                DateTime mydate = DateTime.Now;
                StaticInfoDay = tmp.ShowInfoSalesForDay(mydate.ToString("dd/MM/yyyy"));

              StaticInfoMonth = tmp.ShowInfoSalesForMonthLbl();
                
                lblDay.Text = "מכירות יומי "+"\n" + StaticInfoDay.getSales();
                lblMonth.Text = "מכירות חודשי"+"\n" + StaticInfoMonth.getSales();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stock_management s1 = new stock_management();
            s1.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales_management s2 = new Sales_management();
            s2.ShowDialog();
        }

        private void btnBid_Click(object sender, EventArgs e)
        {
            Bid_management b1 = new Bid_management();
            b1.ShowDialog();
        }

        private void btnstatistics_Click(object sender, EventArgs e)
        {
            Statistics_Manage s1 = new Statistics_Manage();

            s1.ShowDialog();
                
              
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            Suppliers p1 = new Suppliers();
            p1.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users_Management u1 = new Users_Management();
            u1.ShowDialog();
        }

        private void btnInsights_Click(object sender, EventArgs e)
        {
            Insights_management i1 = new Insights_management();
            i1.ShowDialog();
        }

        private void btnOrderSuppliers_Click(object sender, EventArgs e)
        {
            Orders_Suppliers o1 = new Orders_Suppliers(_NameUser);
            o1.ShowDialog();
        }

        private void btnOrderFromSuppliers_Click(object sender, EventArgs e)
        {
            OrderFromSuppliers f1 = new OrderFromSuppliers();
            f1.ShowDialog();
        }
    }
}
