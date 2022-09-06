using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Business_For_You
{
    public partial class Dashboard_Salesman : Form
    {
        protected string _NameUser;
        private Category tmpCategory = new Category();
        private Statistics_info StaticInfoDay;

        private Statistics_info StaticInfoMonth;

        private Statistics_info tmp = new Statistics_info();

        private List<string> allCategory = new List<string>();

        public Dashboard_Salesman(string str,int bdikamaneg)
        {
           

            _NameUser = str;
            InitializeComponent();
            customsubmenu();
            lblwellcome.Text +=" "+ str;

            if (bdikamaneg == 1)
                btnManagement.Visible = true;

            CategoryForBtn();
            infoForLblDayAndMonth(_NameUser);






        }


        private void infoForLblDayAndMonth( string nameUs )
        {
            try
            {
                DateTime mydate = DateTime.Now;
                StaticInfoDay = tmp.ShowInfoSalesForDaySalesman(mydate.ToString("dd/MM/yyyy"), nameUs);

                StaticInfoMonth = tmp.ShowInfoSalesForMonthLblSalesman(nameUs);

                lblDay.Text = "מכירות יומי " + "\n" + StaticInfoDay.getSales();
                lblMonth.Text = "מכירות חודשי" + "\n" + StaticInfoMonth.getSales();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CategoryForBtn()
        {
            try
            {
                allCategory.Clear();



                allCategory = tmpCategory.ShowListforBtnMenu();
                  


               

                btnType1.Text = allCategory[0];
                btnType2.Text = allCategory[1];
                btnType3.Text = allCategory[2];


               

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void customsubmenu()
        {
            panelSubmenu.Visible = false;
        }

        private void hidesubmenu()
        {
            if(panelSubmenu.Visible == true)
            {
                panelSubmenu.Visible = false;
            }
        }

        private void showsubmenu(Panel subMenu)
        {
            if (panelSubmenu.Visible == false)
            {
                hidesubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void Dashboard_Salesman_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProudect_Click(object sender, EventArgs e)
        {
            showsubmenu(panelSubmenu);
        }

        private void btnType1_Click(object sender, EventArgs e)
        {
            ProudectType_1 p1 = new ProudectType_1();
            p1.ShowDialog();
            ///
            ///mycode
            ///
            hidesubmenu();
        }

        private void btnType2_Click(object sender, EventArgs e)
        {
            ProductType_2 p2 = new ProductType_2();
            p2.ShowDialog();
            ///
            ///mycode
            ///
            hidesubmenu();
        }

        private void btnType3_Click(object sender, EventArgs e)
        {
            ProductType_3 p3 = new ProductType_3();
            p3.ShowDialog();
            ///
            ///mycode
            ///
            hidesubmenu();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales s1 = new Sales(_NameUser);
            s1.ShowDialog();
        }

        private void btnNewsale_Click(object sender, EventArgs e)
        {
            new_order n1 = new new_order(_NameUser);
            n1.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBids_Click(object sender, EventArgs e)
        {
            Bid b1 = new Bid(_NameUser);
            b1.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelsidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

     
        private void btnContacts_Click(object sender, EventArgs e)
        {
            Contacts c1 = new Contacts();
            c1.ShowDialog();
        }

        private void btnInsights_Click(object sender, EventArgs e)
        {
            Insights_Salesman i1 = new Insights_Salesman(_NameUser);
            i1.ShowDialog();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            Statistics_Salesman s1 = new Statistics_Salesman(_NameUser);
            s1.ShowDialog();
        }

        private void btnManagement_Click_1(object sender, EventArgs e)
        {
            Dashboard_Manager m1 = new Dashboard_Manager(_NameUser);
            m1.ShowDialog();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            SendEmail sm1 = new SendEmail();
            sm1.ShowDialog();
        }
    }
}
