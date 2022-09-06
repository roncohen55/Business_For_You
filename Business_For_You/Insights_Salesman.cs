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
    public partial class Insights_Salesman : Form
    {
        private Insights_class tmpInsights = new Insights_class();

        private Insights_class _InfoInsights;

        public Insights_Salesman( string nameUs )
        {
            InitializeComponent();
            ShowInsights(nameUs);
        }


        private void ShowInsights( string NameSalesman )
        {
            try
            {
                listBox1.Items.Clear();
                List<string> tmp1 = new List<string>();
                tmp1 = tmpInsights.ShowListForSalesman(NameSalesman);
                for (int i = 0; i < tmp1.Count; i++)
                    listBox1.Items.Add(tmp1[i]);

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //show all data from one Insights
        private void ShowinfoFromdata()
        {
            try
            {
                _InfoInsights = tmpInsights.ShowinfoFromdata(listBox1.Text);

                string str = "";

                str = "פרטי תובנה" + "\n" + "מספר עובד" + " " + _InfoInsights.getId().ToString() + "\n" + "שם עובד" + " " + _InfoInsights.getName() + "\n" + "הערות" + " " + _InfoInsights.getNote() + "\n" + "דירוג" + " " + _InfoInsights.getRating().ToString() + "\n" + "תאריך" + " " + _InfoInsights.getDate();

                lblInfo.Text = str;

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ShowinfoFromdata();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
