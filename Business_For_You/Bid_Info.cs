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
    public partial class Bid_Info : Form
    {
        private string _Nameuser;
        private int _id = 1;
        private float _price;
        private string _camot;
        private string _info;
       

        public Bid_Info( float price, string info, string camot, string nameus)
        {
            InitializeComponent();
            _price = price;
            _info = info;
            _camot = camot;
            _Nameuser = nameus;
         
        }

        //check phone and name bayer
        private int check()
        {
            int c = 0, crev = 0, cbdika = 0, cPhone = 0;
            string str = txtNameBayer.Text;
            string st = txtPhone.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'א' && str[i] <= 'ת' || str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                    c++;
                else if (str[i] == ' ')
                    crev++;
            }
            if (str.Length - c - crev == 0 && crev < 2)
                cbdika += 1;
            for (int j = 0; j < st.Length; j++)
            {
                if (st[j] >= '0' && st[j] <= '9')
                    cPhone++;

            }

            if (st.Length - cPhone == 0 && cPhone == 10)
                cbdika += 1;

            return cbdika;



        }

     

        //Insert Bid
        private void insert()
        {
            try
            {
                Bids_class b1 = new Bids_class();
                b1.Insert(_info,_camot,_price,txtNameBayer.Text,txtPhone.Text,txtAddress.Text,txtNote.Text,txtEmail.Text, _Nameuser);          
                MessageBox.Show("Insert   Row");   
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNameBayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (check() == 2)
            {
                string str = "לשמור הצעת מחיר ?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result = MessageBox.Show(str, "Business For You", buttons);
                if (result == DialogResult.Yes)
                {
                    insert();
                    this.Close();
                }
            }
            else
                MessageBox.Show("הנתונים שהוזנו שגואים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
