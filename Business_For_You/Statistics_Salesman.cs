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
    public partial class Statistics_Salesman : Form
    {
        private string _NameUser;

        private Statistics_info StaticInfo;

        private Statistics_info tmp = new Statistics_info();

        public Statistics_Salesman( string nameUs )
        {
            InitializeComponent();
            _NameUser = nameUs;
            AddDateForComboBoxDateByDayDefult();
        }


        private void AddDateForComboBoxDateByDayDefult()
        {
            try
            {

                comboBoxDate.Items.Clear();
                List<DateTime> tmp1 = new List<DateTime>();
                tmp1 = tmp.ShowDateSalesForDay();
                for (int i = 0; i < tmp1.Count; i++)
                    comboBoxDate.Items.Add(tmp1[i]);

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }







        private void ShowInfoForDate()
        {
            try
            {
                if (comboBox1.Text == "יומי")
                {
                    StaticInfo = tmp.ShowInfoSalesForDaySalesman(comboBoxDate.Text, _NameUser);
                }

                else if (comboBox1.Text == "חודשי")
                {
                    StaticInfo = tmp.ShowInfoSalesForMonthSalesman(comboBoxDate.Text, _NameUser);
                }

                else if (comboBox1.Text == "שנתי")
                {
                    StaticInfo = tmp.ShowInfoSalesForYearSalesman(comboBoxDate.Text, _NameUser);
                }


                lblinfoCount.Text =  StaticInfo.getCountSales().ToString();
                lblinfoSales.Text = "₪ " + StaticInfo.getSales();
               // lblinfoProfit.Text = "₪" + StaticInfo.getProfit();
               // lblinfoExpo.Text = "₪ " + StaticInfo.getExpenses();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }





        private void Funcdiagrm3()
        {
            try
            {
                if (comboBox1.Text == "יומי")
                    StaticInfo = tmp.ShowInfoSalesForDaySalesman(comboBoxDate.Text , _NameUser);
                else if (comboBox1.Text == "חודשי")
                    StaticInfo = tmp.ShowInfoSalesForMonthSalesman(comboBoxDate.Text , _NameUser);

                else if (comboBox1.Text == "שנתי")
                    StaticInfo = tmp.ShowInfoSalesForYearSalesman(comboBoxDate.Text , _NameUser);

                /* Statistics_info InfoForDiagremDate = StaticInfo.FuncInfoForDiagrm1(StaticInfo.getSales(), StaticInfo.getExpenses(), StaticInfo.getProfit(), StaticInfo.getCountSales());
                 lblSales.Size = new Size(80, int.Parse(InfoForDiagremDate.getSales().ToString()));
                 lblSales.BackColor = System.Drawing.Color.Blue;
                 lblSales.AutoSize = false;

                 lblExpenses.Size = new Size(80, int.Parse(InfoForDiagremDate.getExpenses().ToString()));
                 lblExpenses.BackColor = System.Drawing.Color.Red;
                 lblExpenses.AutoSize = false;

                 lblProfit.Size = new Size(80, int.Parse(InfoForDiagremDate.getProfit().ToString()));
                 lblProfit.BackColor = System.Drawing.Color.Green;
                 lblProfit.AutoSize = false;

                 lblCountSales.Size = new Size(80, InfoForDiagremDate.getCountSales());
                 //lblGlobalSpending.BackColor = System.Drawing.Color.Red;
                 lblCountSales.AutoSize = false;*/

                chart1.Series["תזרים המכירות שלך"].Points.Clear();
                chart1.Series["תזרים המכירות שלך"].Points.Clear();
              //  chart1.Series["תזרים המכירות שלך"].Points.Clear();
              //  chart1.Series["תזרים המכירות שלך"].Points.Clear();

               // chart1.Series["תזרים המכירות שלך"].Points.AddXY("רווחים", StaticInfo.getProfit());
                //chart1.Series["תזרים המכירות שלך"].Points.AddXY("הוצאות", StaticInfo.getExpenses());
                chart1.Series["תזרים המכירות שלך"].Points.AddXY("מכירות", StaticInfo.getSales());
                chart1.Series["תזרים המכירות שלך"].Points.AddXY("כמות מכירות", StaticInfo.getCountSales());

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBoxDate.Text == "")
                MessageBox.Show("הנתונים שהוזנו שגואים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {

                Funcdiagrm3();
                ShowInfoForDate();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (comboBox1.Text == "יומי")
                {
                    comboBoxDate.Items.Clear();
                    List<DateTime> tmp1 = new List<DateTime>();
                    tmp1 = tmp.ShowDateSalesForDay();
                    for (int i = 0; i < tmp1.Count; i++)
                        comboBoxDate.Items.Add(tmp1[i]);
                }


                else if (comboBox1.Text == "חודשי")
                {
                    comboBoxDate.Items.Clear();
                    List<string> tmp1 = new List<string>();
                    tmp1 = tmp.ShowDateSalesForMonth();
                    for (int i = 0; i < tmp1.Count; i++)
                        comboBoxDate.Items.Add(tmp1[i]);
                }

                else if (comboBox1.Text == "שנתי")
                {
                    comboBoxDate.Items.Clear();
                    List<string> tmp1 = new List<string>();
                    tmp1 = tmp.ShowDateSalesForYear();
                    for (int i = 0; i < tmp1.Count; i++)
                        comboBoxDate.Items.Add(tmp1[i]);
                }
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
