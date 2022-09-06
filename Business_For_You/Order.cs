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
    public partial class Order : Form
    {
        private string _camotFromproducts;
        private string _Nameuser;
        private int _id=1;
        private float _price;
        private string _camot;
        private string _info;
        private string _inStr;
        private float _PriceForme = 0;
        private Sales_class tmp = new Sales_class();
        private Sales_class _SaleInfo11 = new Sales_class();
        private Products_class _tmpProduct = new Products_class();
        private List<Products_class> _listProduct = new List<Products_class>();
        private List<Sales_class> _listSale = new List<Sales_class>();
        private List<Sales_class> _tmplistCustomers2 = new List<Sales_class>();



        public Order(string str,float price,string info,string camot,string nameus,string camotfromproducts)
        {
            InitializeComponent();
            label1.Text = str;
            
            _price = price;
            _info = info;
            _camot = camot;
            _inStr = str;
            
            _Nameuser = nameus;
            _camotFromproducts = camotfromproducts;

           // giveMemakatforPrice(str);

            _listProduct.Clear();
            _listProduct = _tmpProduct.ShowListObject();
            _listSale.Clear();
            _listSale = tmp.ShowListObject();
            ShowCustomers();


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
            int id = 0, c = 0 , cBodak = 0;
            string strId = "";
            for(int i=0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    c++;
                if (c == 0 && str[i] >= '0' && str[i] <= '9')
                    strId += str[i];
            }

            if(strId == "")
                MessageBox.Show("לא נמצא לקוח", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            { 
              id = int.Parse(strId);
                  
            for (int j=0; j<_tmplistCustomers2.Count; j++)
            {
                if (id == _tmplistCustomers2[j].getId())
                {
                    _SaleInfo11 = _tmplistCustomers2[j];
                    cBodak++;
                }
                   
            }

            if(cBodak > 0)
            {
                txtNamebayer.Text = _SaleInfo11.getName();
                txtNumberphone.Text = _SaleInfo11.getPhone();
                txtEmail.Text = _SaleInfo11.getEmail();
                txtAdrress.Text = _SaleInfo11.getAddress();
            }

            else
                MessageBox.Show("לא נמצא לקוח", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private string givemecamotFromProduct(string makat)
        {
            
            string camotFromProduct = "";
           for(int i=0; i < _listProduct.Count; i++)
            {
                if (int.Parse(_listProduct[i].getMakat()) == int.Parse(makat))
                    camotFromProduct = _listProduct[i].getQuantity().ToString();
            }
            return camotFromProduct;
        }

        //show makat and camot
       private void deletecamot(string str)
        {
            int c=0,newcamot=0;
            string camot="", makat="";
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == '*')
                {
                    c = 0;
                    camot = "";
                    makat = "";
                }
                if (str[i] == '-')
                    c++;
                else if (c == 0 && str[i]>='0' && str[i]<='9')
                    makat += str[i];
                else if (c == 2)
                    camot += str[i];
                if (str[i] == ',')
                {
                    if (givemecamotFromProduct(makat) == "")
                        newcamot = 0;
                    else
                        newcamot = int.Parse(givemecamotFromProduct(makat)) - int.Parse(camot);
                    if(newcamot > 0)
                        deletecamotFromProduct(makat, newcamot);
                   
                }
            
                
            }      
            
        }
        //update product
       private void deletecamotFromProduct(string makat,int camot)
         {
             try
             {

                string str = "", s = "";

                str = makat + " ~ " + camot;

                string pac = "G#" + str;

                funcServer f1 = new funcServer();
                s = f1.dataStringFromServer(pac);
                MessageBox.Show("update {0} proudect" );
             }

             catch (Exception err)
             {
                 MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

        }

        //makar for price for me
       /* private void giveMemakatforPrice(string str )
        {
             int c = 0;
              string camot="" , makat="" ;
             for (int i = 0; i < str.Length; i++)
             {
                 if (str[i] == '*')
                 {
                     c = 0;
                     camot = "";
                     makat = "";
                 }
                 if (str[i] == '-')
                     c++;
                 else if (c == 0 && str[i] >= '0' && str[i] <= '9')
                     makat += str[i];
                 else if (c == 2)
                     camot += str[i];
                 if (str[i] == ',')
                 {
                     ShowpiceForTheBussinses(makat, int.Parse(camot));
                 }


             }
           
        }*/

        private void givemeID()
        {
            try
            {
       
              for(int i=0; i < _listSale.Count; i++)
                {
                    _id = _listSale[i].getId();
                }
               
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Insert order
        private void insert()
        {
            try
            {
                 

                tmp.Insert(_info ,_camot , _price , txtNamebayer.Text , txtNumberphone.Text , txtAdrress.Text , txtNote.Text , txtEmail.Text , _Nameuser , _PriceForme);
                MessageBox.Show("Insert  Row");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


      /*  private void ShowpiceForTheBussinses(string makat , int camot)
        {
            try
            {
                _listProduct.Clear();
                _listProduct = _tmpProduct.ShowListObject();
                float price = 0;
               

                for(int i=0; i < _listProduct.Count; i++)
                {
                    if (int.Parse(_listProduct[i].getMakat()) == int.Parse(makat.ToString()))
                    {
                        price=float.Parse(_listProduct[i].getPriceForBusiness().ToString());
                    }

                    

                }


                _PriceForme +=price*camot;


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/


        //check phone and name bayer
        private int check()
        {
            int c = 0,crev=0,cbdika=0,cPhone=0;
            string str = txtNamebayer.Text;
            string st = txtNumberphone.Text;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'א' && str[i] <= 'ת' || str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                    c++;
                else if (str[i] == ' ')
                    crev++;
            }
            if (str.Length - c - crev == 0 && crev < 2)
                cbdika += 1;
            for(int j = 0; j < st.Length; j++)
            {
                if (st[j] >= '0' && st[j] <= '9')
                    cPhone++;

            }

            if (st.Length - cPhone == 0 && cPhone == 10)
                cbdika += 1;

            return cbdika;
            

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnasraioption_Click(object sender, EventArgs e)
        {
          
        }

        private void btnmazoman_Click(object sender, EventArgs e)
        {
             if (check() == 2)
             {
                 string str = "לתשלום " + _price;
                 MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                 DialogResult result = MessageBox.Show(str, "Business For You", buttons);
                 if (result == DialogResult.Yes)
                 {
                     insert();
                     deletecamot(_inStr);
                     this.Close();
                 }
             }
             else
                 MessageBox.Show("הנתונים שהוזנו שגואים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
            

        }

        private void btnasrai_Click(object sender, EventArgs e)
        {
            // int c = check();
            //txtNumberasrai.Text = c.ToString();
            //deletecamot(_inStr);




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCustomers(comboBoxCustomers.Text);
        }
    }
}


            