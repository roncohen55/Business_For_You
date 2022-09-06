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
    public partial class Bid : Form
    {
        private Bids_class tmp = new Bids_class();

        private Bids_class _BidInfo11;

        private string _NameUs;

        private List<Bids_class> _listObjectBids = new List<Bids_class>();

        public Bid(string nameUs)
        {
            InitializeComponent();
            _NameUs = nameUs;
            _listObjectBids = tmp.ShowListObject();
            ShowBids(nameUs);
        }

        //show bids from sql
        private void ShowBids(string nameUser)
        {
            try
            {
                listBox1.Items.Clear();

                List<string> tmp1 = new List<string>();
                tmp1 = tmp.ShowListForSalesman(nameUser);
                for (int i = 0; i < tmp1.Count; i++)
                    listBox1.Items.Add(tmp1[i]);

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //show all data from one bid
        private void ShowinfoFromdata()
        {
            try
            {
                _BidInfo11 = tmp.ShowinfoFromdata(listBox1.Text);

                string str = "";

                str = "פרטי הצעת מחיר" + "\n" + "מספר הצעת מחיר" + " " + _BidInfo11.getId().ToString() + "\n" + "מוצרים" + " " + _BidInfo11.getInfo() + "\n" + "מוצרים וכמות" + " " + _BidInfo11.getQuantityInfo() + "\n" + "מחיר" + " " + _BidInfo11.getPrice().ToString() + "\n" + "שם הקונה" + " " + _BidInfo11.getName() + "\n" + "שם המוכר" + " " + _BidInfo11.getSalesman() + "\n" + "מספר פאלפון" + " " + _BidInfo11.getPhone() + "\n" + "כתובת" + " " + _BidInfo11.getAddress() + "\n" + "הערות" + " " + _BidInfo11.getNote() + "\n" + "אימייל" + " " + _BidInfo11.getEmail() + "\n" + _BidInfo11.getDate();

                lblInformation.Text = str;

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //delete one bid
        private void DeleteBid()
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

      



        private void button1_Click(object sender, EventArgs e)
        {
            ShowinfoFromdata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                for (int i = 0; i < _listObjectBids.Count; i++)
                {
                    if (int.Parse(txtSearch.Text) == _listObjectBids[i].getId() && _listObjectBids[i].getSalesman().Trim() == _NameUs.Trim())
                    {
                        str = string.Format("{0,-3}{1,10}{2,10:#.00} {3,12}", _listObjectBids[i].getId(), _listObjectBids[i].getName(), _listObjectBids[i].getPrice(), _listObjectBids[i].getDate());
                        //str = string.Format("{0,-3}{1,10}{2,10:#.00} {3,12}", _listObjectSale[i].getId(), _listObjectSale[i].getName(), _listObjectSale[i].getPrice(), _listObjectSale[i].getDate());
                    }

                }
                if (str != "")
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(str);
                }

                else
                    MessageBox.Show("לא נמצא הצעה", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAllBids_Click(object sender, EventArgs e)
        {
            ShowBids(_NameUs);
        }
    }
}
