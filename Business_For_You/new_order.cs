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
    public partial class new_order : Form
    {
        private string _camotFromProduct;

        private string _nameUser;

        private Products_class tmp = new Products_class();

        private Products_class _ProductInfo = new Products_class() ;

        private List<string> _ListAllProduct = new List<string>();

        private List<Products_class> _ListObjectforSearch = new List<Products_class>();

        public new_order( string nameus )
        {
            InitializeComponent();
            _ListAllProduct = tmp.ShowListNewOrder();
            Showproduct();

            _ListObjectforSearch = tmp.ShowListObject();
          
            _nameUser = nameus;

        }

     
     //add productlist item to txt box info for change and ahow info for camot
        private void addProductlist_item_to_txtbox(string str)
        {
            try
            {
                _ProductInfo = tmp.ShowinfoFromdata(str);

                txtMakat.Text = _ProductInfo.getMakat();
                txtNameProduct.Text = _ProductInfo.getName();
                txtPrice.Text = _ProductInfo.getPrice().ToString();

                //camot for order
                _camotFromProduct += "*" + txtMakat.Text + " - " + txtquantity.Text + "," + "\n";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Insertoneworder()
        {


                int c = 0;
                string s = txtPrice.Text;
                string st = txtquantity.Text;
                
                for (int i = 0; i < st.Length; i++)
                {
                if (st[i] >= '0' && st[i] <= '9' || st[i]=='.')
                    c += 1;
                else
                    c *= 0;
                }

                for (int j = 0; j < s.Length; j++)
                {
                if (s[j] >= '0' && s[j] <= '9'|| s[j]=='.')
                    c += 1;
                else
                    c *= 0;
                }

            if ((s.Length + st.Length) - c == 0 && s.Length!= 0 && st.Length!=0 && txtNameProduct.Text.Length != 0)
            {

                string str = "";


                if (checkBoxProductClali.Checked)
                {
 
                    str = string.Format("{0,-3}{1,20}{2,6}{3,8:#.00}", txtMakat.Text, txtNameProduct.Text, txtquantity.Text, txtPrice.Text);
                    listboxNeworder.Items.Add(str);
                }
                else if (txtMakat.Text == _ProductInfo.getMakat())
                {

                     str = string.Format("{0,-3}{1,20}{2,6}{3,8:#.00}", _ProductInfo.getMakat(), _ProductInfo.getName(), txtquantity.Text, _ProductInfo.getPrice());
                    listboxNeworder.Items.Add(str);
                }

                else
                    MessageBox.Show("הנתונים שהוכנסו שגואיים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
                MessageBox.Show("הנתונים שהוכנסו שגואיים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private string ShowPrice(string str)
        {
            string[] s = new string[4];
            int c = 0;
            string[] st = str.Split(' ');

            for (int j = 0; j < st.Length; j++)
            {
                if (funcTocreateArry(st[j]) != "##")
                {
                    s[c] = funcTocreateArry(st[j]);
                    c++;
                }


            }
                       
             double result = 0;
             int camot = 0;
           
             camot = int.Parse(s[1]);
             result = double.Parse(s[2]) * camot;
             return result.ToString();
        }

        //func to price for business ans sale
        private string showPriceForBusiness(string str)
        {
            string[] s = new string[4];
            int c = 0;
            string[] st = str.Split(' ');

            for (int j = 0; j < st.Length; j++)
            {
                if (funcTocreateArry(st[j]) != "##")
                {
                    s[c] = funcTocreateArry(st[j]);
                    c++;
                }


            }

            double result = 0;
            int camot = 0;

            for(int i=0; i < _ListObjectforSearch.Count; i++)
            {
                if (_ListObjectforSearch[i].getMakat() == s[0].Trim())
                    result = _ListObjectforSearch[i].getPriceForBusiness();
            }

            camot = int.Parse(s[1]);
            result = result * camot;
            return result.ToString();
        }


        private void Showproduct()
        {

            try
            {
                listboxProduct.Items.Clear();
                for (int i = 0; i < _ListAllProduct.Count; i++)
                    listboxProduct.Items.Add(_ListAllProduct[i]);

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       



        private string funcForInfoOrder()//func2
        {
       

            int i = 0;
            string order = "";
            string[] s = new string[4];
            for (i = 0; i < listboxNeworder.Items.Count; i++)
            {
                string str = listboxNeworder.Items[i].ToString();
                string[] st = str.Split(' ');
                int c = 0;
                for (int j = 0; j < st.Length; j++)
                {
                    if (funcTocreateArry(st[j]) != "##")
                    {
                        s[c] = funcTocreateArry(st[j]);
                        c++;
                    }


                }

                

                order += "*" + s[0].Trim() +" - "+str.Substring(6,22).Trim() + " - "+s[1].Trim() + " - " +s[2].Trim() + "," + "\n";
            }

            return order;

        }
    
        


        private string func3(string str)
        {
            
            string info="",makat="",nameProduct="";
            string[] s = new string[4];
            int c = 0;
            string[] st = str.Split(' ');

            for (int j = 0; j < st.Length; j++)
            {
                if (funcTocreateArry(st[j]) != "##")
                {
                    s[c] = funcTocreateArry(st[j]);
                    c++;
                }


            }
            nameProduct = str.Substring(6, 22);
            makat = s[0];
            info = makat + " " + nameProduct.Trim();
            return info+"\n";

        }

        private string Showcamot(string str)
        {
            string  strcamot = "",name="";
            int c = 0;
            string[] s = new string[4];
            string[] st = str.Split(' ');

            for (int j = 0; j < st.Length; j++)
            {
                if (funcTocreateArry(st[j]) != "##")
                {
                    s[c] = funcTocreateArry(st[j]);
                    c++;
                }


            }
            strcamot = s[1];
            name = str.Substring(6, 22);

            return name.Trim()+" "+strcamot+"\n" ;
        }


        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                addProductlist_item_to_txtbox(listboxProduct.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string funcTocreateArry(string str)
        {
            int i, c = 0;
            for (i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z' || str[i] >= 'a' && str[i] <= 'z' || str[i] >= '0' && str[i] <= 'z')
                    c++;
            }
            if (c > 0)
                return str;
            return "##";
        }

       

        private void btnInsertToclass_Click(object sender, EventArgs e)
        {
            try
            {
                Insertoneworder();
              
                int i ;
                  double prices = 0 ;
                  for (i = 0; i < listboxNeworder.Items.Count; i++)
                  {
                    prices += double.Parse(ShowPrice(listboxNeworder.Items[i].ToString()));
                  }
                  txtpricelifnimam.Text = prices.ToString();
                  double aftermam = ((prices) + prices * 0.17);
                  lblpriceafter.Text = aftermam.ToString();
    
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpricelifnimam_TextChanged(object sender, EventArgs e)
        {
            if(txtpricelifnimam.Text == "")
                txtpricelifnimam.Text = "0";
            int c = 0 , cNakoda=0;
             for(int i = 0; i < txtpricelifnimam.Text.Length; i++)
             {
                if (txtpricelifnimam.Text[i] >= '0' && txtpricelifnimam.Text[i] <= '9')
                    c++;
                else if (txtpricelifnimam.Text[i] == '.')
                    cNakoda++;
             }
             if((c+cNakoda) != txtpricelifnimam.Text.Length || cNakoda>1 || txtpricelifnimam.Text == ".")
            {
               // MessageBox.Show("הנתונים שהוזנו שגואים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpricelifnimam.Text = "0";
            }
                
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                 double results = double.Parse(txtpricelifnimam.Text) - double.Parse(ShowPrice(listboxNeworder.Text));
                 //_PriceForBusiness -= double.Parse(showPriceForBusiness(listboxNeworder.Text));
                listboxNeworder.Items.Remove(listboxNeworder.Text);
                 txtpricelifnimam.Text = results.ToString();
                 lblpriceafter.Text = ((results) + results * 0.17).ToString();
               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            try
            {
                string info = "", camot = "";
                for (int i = 0; i < listboxNeworder.Items.Count; i++)
                {
                    info += func3(listboxNeworder.Items[i].ToString());
                    camot += Showcamot(listboxNeworder.Items[i].ToString());


                }
                float price = float.Parse(lblpriceafter.Text);
                Order o1 = new Order(funcForInfoOrder(), price, info, camot, _nameUser, _camotFromProduct);
                o1.ShowDialog();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void new_order_Load(object sender, EventArgs e)
        {

        }

        private void lblpriceafter_Click(object sender, EventArgs e)
        {
            if(txtpricelifnimam.Text != "" || txtpricelifnimam.Text != ".")
            {
                int i;
                double price = double.Parse(txtpricelifnimam.Text) + (double.Parse(txtpricelifnimam.Text) * 0.17);
                double realPrice = 0,minPrice=0 , priceForTheBusiness = 0;
                for (i = 0; i < listboxNeworder.Items.Count; i++)
                {
                    realPrice += double.Parse(ShowPrice(listboxNeworder.Items[i].ToString()));
                }

                realPrice += (realPrice * 0.17);
                minPrice = realPrice - (realPrice * 0.3);

                for (i = 0; i < listboxNeworder.Items.Count; i++)
                {


                    priceForTheBusiness += double.Parse(showPriceForBusiness(listboxNeworder.Items[i].ToString()));
                }

                if (price > minPrice && price > priceForTheBusiness)
                    lblpriceafter.BackColor = System.Drawing.Color.Green;
                else
                    lblpriceafter.BackColor = System.Drawing.Color.Red;
                lblpriceafter.Text = price.ToString();
            }
            else
                MessageBox.Show("הנתונים שהוזנו שגואים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnBid_Click(object sender, EventArgs e)
        {
            try
            {
                string info = "", camot = "";
                for (int i = 0; i < listboxNeworder.Items.Count; i++)
                {
                    info += func3(listboxNeworder.Items[i].ToString());
                    camot += Showcamot(listboxNeworder.Items[i].ToString());


                }
                float price = float.Parse(lblpriceafter.Text);
                Bid_Info b1 = new Bid_Info(price, info, camot, _nameUser);
                b1.ShowDialog();
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

      /*  private void radioProductClali_CheckedChanged(object sender, EventArgs e)
        {
            if (radioProductClali.Checked)
                txtMakat.Text = "000";
            else if (radioProductClali.Checked && txtMakat.Text != "000")
                txtMakat.Text = "000";
        }*/

        private void checkBoxProductClali_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProductClali.Checked)
                txtMakat.Text = "000";
            else if (checkBoxProductClali.Checked && txtMakat.Text != "000")
                txtMakat.Text = "000";
          

        }

        private void txtMakat_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxProductClali.Checked)
                txtMakat.Text = "000";
            else if (checkBoxProductClali.Checked && txtMakat.Text != "000")
                txtMakat.Text = "000";
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {        
            string str = "";
            for(int i = 0; i < _ListObjectforSearch.Count; i++)
            {
                if (txtSearch.Text == _ListObjectforSearch[i].getMakat())
                {

                    str = string.Format("{0,-3}{1,5}{2,20}{3,6} {4,8:#.00}", _ListObjectforSearch[i].getId(), _ListObjectforSearch[i].getMakat(), _ListObjectforSearch[i].getName(), _ListObjectforSearch[i].getQuantity(), _ListObjectforSearch[i].getPrice());
                }
                    
            }
            if (str != "")
            {
                listboxProduct.Items.Clear();
                listboxProduct.Items.Add(str);
            }
                
            else
                MessageBox.Show("לא נמצא מוצר", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAllProduct_Click(object sender, EventArgs e)
        {
            Showproduct();
        }
    }
}
