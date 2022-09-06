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
    public partial class Orders_Suppliers : Form
    {
        private Products_class tmp = new Products_class();

        private Suppliers_Class tmpSuppliers = new Suppliers_Class();

        private OrdersSuppliers_class tmpSuppliersOrder = new OrdersSuppliers_class();

        private Suppliers_Class _suppliersInfo = new Suppliers_Class();

        private Products_class _ProductInfo = new Products_class();

        private List<Suppliers_Class> _ListObjectSuppliers = new List<Suppliers_Class>();

        private List<Products_class> _ListObjectforSearch = new List<Products_class>();

        private string _NameUser;

        public Orders_Suppliers(string nameus)
        {
            InitializeComponent();
            _NameUser = nameus;
            _ListObjectSuppliers = tmpSuppliers.ShowListObject();
            _ListObjectforSearch = tmp.ShowListObject();
            ShowProductMakatForCombo();
            ShowSuppliersCombo();
        }

        private void ShowProductMakatForCombo()
        {
            string str = "";
            comboBoxProduct.Items.Clear();
            for(int i=0; i < _ListObjectforSearch.Count; i++)
            {
                str = _ListObjectforSearch[i].getMakat();
                comboBoxProduct.Items.Add(str);
            }
        }

        private void ShowSuppliersCombo()
        {
            string str = "";
            comboBoxSuppliers.Items.Clear();
            for(int i=0; i<_ListObjectSuppliers.Count; i++)
            {
                str = _ListObjectSuppliers[i].getId() + " " + _ListObjectSuppliers[i].getName();
                comboBoxSuppliers.Items.Add(str);
            }
        }

        //func to search Product
        public void SearchProduct(string str)
        {
            int  cBodak = 0;
          
            

            if (str == "")
                MessageBox.Show("לא נמצא מוצר", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
            

                for (int j = 0; j < _ListObjectforSearch.Count; j++)
                {
                    if (str.Trim() == _ListObjectforSearch[j].getMakat())
                    {
                        _ProductInfo = _ListObjectforSearch[j];
                        cBodak++;
                    }

                }

                if (cBodak > 0)
                {
                    lblMakat.Text = _ProductInfo.getMakat();
                    lblNameProduct.Text = _ProductInfo.getName();
                    lblPriceForMe.Text = _ProductInfo.getPriceForBusiness().ToString();
                    lblQuntity.Text = _ProductInfo.getQuantity().ToString();
                }

                else
                    MessageBox.Show("לא נמצא מוצר", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //func to search Suppliers
        public void SearchSuppliers(string str)
        {
            int id = 0, c = 0, cBodak = 0;
            string strId = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    c++;
                if (c == 0 && str[i] >= '0' && str[i] <= '9')
                    strId += str[i];
            }

            if (strId == "")
                MessageBox.Show("לא נמצא ספק", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                id = int.Parse(strId);

                for (int j = 0; j < _ListObjectSuppliers.Count; j++)
                {
                    if (id == _ListObjectSuppliers[j].getId())
                    {
                        _suppliersInfo = _ListObjectSuppliers[j];
                        cBodak++;
                    }

                }

                if (cBodak > 0)
                {
                    string result =_suppliersInfo.getName() + " ," + _suppliersInfo.getCompany();
                    lblNameSuppliers.Text = result;
                }

                else
                    MessageBox.Show("לא נמצא ספק", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            for (int i = 0; i < _ListObjectforSearch.Count; i++)
            {
                if (_ListObjectforSearch[i].getMakat() == s[0].Trim())
                    result = _ListObjectforSearch[i].getPriceForBusiness();
            }

            camot = int.Parse(s[1]);
            result = result * camot;
            return result.ToString();
        }


        private void Insertoneworder()
        {


            int c = 0;
            string st = txtNewCamot.Text;

            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] >= '0' && st[i] <= '9' || st[i] == '.')
                    c += 1;
                else
                    c *= 0;
            }


            if ( (st.Length - c) == 0  && st.Length != 0 && st != "0" )
            {

                string str = "";

                str = string.Format("{0,-3}{1,20}{2,6}{3,8:#.00}", lblMakat.Text, lblNameProduct.Text, txtNewCamot.Text, lblPriceForMe.Text);
                listBoxNewOrder.Items.Add(str);
                
               
            }

            else
                MessageBox.Show("הנתונים שהוכנסו שגואיים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private string givemecamotFromProduct(string makat)
        {

            string camotFromProduct = "";
            for (int i = 0; i < _ListObjectforSearch.Count; i++)
            {
                if (int.Parse(_ListObjectforSearch[i].getMakat()) == int.Parse(makat))
                    camotFromProduct = _ListObjectforSearch[i].getQuantity().ToString();
            }
            return camotFromProduct;
        }

        //show makat and camot
        private void deletecamot(string str)
        {
            int c = 0, newcamot = 0;
            string camot = "", makat = "";
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
                    if (givemecamotFromProduct(makat) == "")
                        newcamot = 0;
                    else
                        newcamot = int.Parse(givemecamotFromProduct(makat)) + int.Parse(camot);
                    if (newcamot > 0)
                        deletecamotFromProduct(makat, newcamot);

                }


            }

        }
        //update product
        private void deletecamotFromProduct(string makat, int camot)
        {
            try
            {

                string str = "", s = "";

                str = makat + " ~ " + camot;

                string pac = "G#" + str;

                funcServer f1 = new funcServer();
                s = f1.dataStringFromServer(pac);
                MessageBox.Show("update {0} proudect");
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
            for (i = 0; i < listBoxNewOrder.Items.Count; i++)
            {
                string str = listBoxNewOrder.Items[i].ToString();
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



                order += "*" + s[0].Trim() + " - " + str.Substring(6, 22).Trim() + " - " + s[1].Trim() + " - " + s[2].Trim() + "," + "\n";
            }

            return order;

        }

        //Insert order
        private void insert()
        {
            try
            {
                string info = "";
                for (int i = 0; i < listBoxNewOrder.Items.Count; i++)
                {
                   
                    info += ShowcamotInfo(listBoxNewOrder.Items[i].ToString());


                }

                tmpSuppliersOrder.insertNewSuppliersOrder(lblNameSuppliers.Text, _NameUser, info,float.Parse( lblPriceOrder.Text), "00");
                MessageBox.Show("Insert  Row");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private string ShowcamotInfo(string str)
        {
            string strcamot = "", name = "" , makat="";
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
            makat = s[0];
            strcamot = s[1];
            name = str.Substring(6, 22);

            return makat+" " + name.Trim() + " " + strcamot + "\n";
        }

        private void Orders_Suppliers_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            SearchProduct(comboBoxProduct.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchSuppliers_Click(object sender, EventArgs e)
        {
            SearchSuppliers(comboBoxSuppliers.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {         
            try
            {
                Insertoneworder();

                int i;
                double prices = 0;
                for (i = 0; i < listBoxNewOrder.Items.Count; i++)
                {
                    prices += double.Parse(showPriceForBusiness(listBoxNewOrder.Items[i].ToString()));
                }
                lblPriceOrder.Text = prices.ToString();
                

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                double results = double.Parse(lblPriceOrder.Text) - double.Parse(showPriceForBusiness(listBoxNewOrder.Text));
                listBoxNewOrder.Items.Remove(listBoxNewOrder.Text);
                lblPriceOrder.Text = results.ToString();
              

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Statistics_info s1 = new Statistics_info();
            int c = s1.ShowCountMonthForOrderSuppliers();
            string strInfo = "";
            if(lblNameSuppliers.Text !="" && lblPriceOrder.Text != "0")
            {
                if (c > 0)
                {
                    strInfo = "בוצעו הזמנות מספק החודש כדאי לבדוק שאין כפילויות, לתשלום " + lblPriceOrder.Text + "₪";
                }
                else
                    strInfo = "לא בוצעו עדיין הזמנות מספק החודש ,לתשלום " + lblPriceOrder.Text + "₪";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(strInfo, "Business For You", buttons);

                if (result == DialogResult.Yes)
                {
                    string str = funcForInfoOrder();
                    deletecamot(str);
                    insert();
                }               
            }
            else
                MessageBox.Show("הנתונים שהוכנסו שגואיים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);         

        }
    }
}
