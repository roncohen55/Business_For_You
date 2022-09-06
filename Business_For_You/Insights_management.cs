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
    public partial class Insights_management : Form
    {
        private Users_class tmp = new Users_class();

        private Insights_class tmpInsights = new Insights_class();

        private Insights_class _InfoInsights;


        private List<Users_class> _allUsersObject = new List<Users_class>();

        public Insights_management()
        {
            InitializeComponent();
            ShowUsers();
            ShowRatingForCombo();
            ShowInsights();

        }

        private void ShowUsers()
        {
            try
            {
                string str;
                comboBoxUsers.Items.Clear();
                _allUsersObject.Clear();

                _allUsersObject = tmp.ShowListObject();

                for (int i = 0; i < _allUsersObject.Count; i++)
                {
                   
                        str = _allUsersObject[i].getId() + " " +  _allUsersObject[i].getName();
                   
                        
                         comboBoxUsers.Items.Add(str);
                }

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string funcHelpList(string str)
        {
            string[] tmp = str.Split(' ');
            return tmp[1];
        }

        private void ShowRatingForCombo()
        {
            try
            {
                int num = 10;
                comboBoxRating.Items.Clear();
            

                for (int i = 1; i <= num; i++)
                {
                    comboBoxRating.Items.Add(i);
                }

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowInsights()
        {
            try
            {
                listBox1.Items.Clear();
                List<string> tmp1 = new List<string>();
                tmp1 = tmpInsights.ShowList();
                for (int i = 0; i < tmp1.Count; i++)
                    listBox1.Items.Add(tmp1[i]);

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertNewInsights()
        {
            try
            {

                tmpInsights.Insert(funcHelpList(comboBoxUsers.Text), txtNote.Text, int.Parse( comboBoxRating.Text));
                MessageBox.Show("Insert Row");


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteInsights()
        {

            try
            {
                tmpInsights.Delete(listBox1.Text);
                MessageBox.Show("Delete Sucsses");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
             insertNewInsights();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteInsights();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ShowinfoFromdata();
        }
    }
}
