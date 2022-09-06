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
    public partial class stock_management : Form
    {
        private  Category tmpCategory = new Category();

        private List<Products_class> _listObjectProduct = new List<Products_class>();

        private Products_class tmpProduct = new Products_class();

        private Products_class _ProductInfo;

     

        public stock_management()
        {
            InitializeComponent();
            _listObjectProduct = tmpProduct.ShowListObject();
            Showproduct();
            ShowCategory();

        }

        private void Showproduct()
        {
            try
            {
                listBoxProduct.Items.Clear();
               List<string> tmp1 = new List<string>();
                tmp1 = tmpProduct.ShowList();
                for (int i = 0; i < tmp1.Count; i++)
                    listBoxProduct.Items.Add(tmp1[i]);

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showListProductCamotLow()
        {
            try
            {
                listBoxProduct.Items.Clear();
                 List<string> tmp1 = new List<string>();
                  tmp1 = tmpProduct.ShowListProductCamotLow();
                for (int i = 0; i < tmp1.Count; i++)
                    listBoxProduct.Items.Add(tmp1[i]);

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ShowCategory()
        {
            try
            {
                comboBoxCategory.Items.Clear();
                listBoxCategory.Items.Clear();
                List<string> tmp1 = new List<string>();
                tmp1 = tmpCategory.ShowList();
                for (int i = 0; i < tmp1.Count; i++)
                {
                    listBoxCategory.Items.Add(tmp1[i]);
                    comboBoxCategory.Items.Add(tmp1[i]);
                }

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addProductlist_item_to_txtbox(string str)
        {
            try
            {
                _ProductInfo = tmpProduct.ShowinfoFromdata(listBoxProduct.Text);

                txtMakat.Text = _ProductInfo.getMakat();
                txtNameProduct.Text = _ProductInfo.getName();
                txtPrice.Text = _ProductInfo.getPrice().ToString();
                txtCamot.Text = _ProductInfo.getQuantity().ToString();
                txtPriceForBusiness.Text = _ProductInfo.getPriceForBusiness().ToString();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private int addTypeForUpdateCategory(string str)
        {
            string typeInString = "";
            int type = 0 , c = 0;
            
            for(int i=0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    c++;
                if (c == 0)
                    typeInString += str[i];
            }

            type = int.Parse(typeInString);

            return type;

        }

        //delete one product
        private void DeleteProduct()
        {

            try
            {
                tmpProduct.Delete(listBoxProduct.Text);
                MessageBox.Show("Delete Sucsses");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteCategory()
        {

            try
            {
                tmpCategory.Delete( listBoxCategory.Text);
                MessageBox.Show("Delete Sucsses");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //בודק עם המקט החדש כבר קיים
      private bool checkTXTmakat(string str) 
      {
          //  _listObjectProduct = tmpProduct.ShowListObject();
            for(int i = 0; i < _listObjectProduct.Count; i++)
            {
                if (str.Trim() == _listObjectProduct[i].getMakat())
                    return false;
            }
            return true;
      }

     

        private void insertNewProduct()
        {
            try
            {
                if(checkTXTmakat(txtMakat.Text) == true)
                {
                    tmpProduct.Insert(txtMakat.Text, txtNameProduct.Text, int.Parse(txtCamot.Text), float.Parse(txtPrice.Text), addTypeForUpdateCategory(comboBoxCategory.Text), float.Parse(txtPriceForBusiness.Text));
                    MessageBox.Show("Insert Row");
                }
                    
                else
                    MessageBox.Show("הנתונים שהוזנו שגואים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insertNewCategory()
        {
            try
            {
                tmpCategory.Insert(txtNameCategory.Text);
                MessageBox.Show("Insert Row");

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

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

            try
            {
                
                Products_class p1 = new Products_class();
                p1.Update(txtMakat.Text, txtNameProduct.Text,int.Parse( txtCamot.Text),float.Parse( txtPrice.Text), addTypeForUpdateCategory(comboBoxCategory.Text), float.Parse( txtPriceForBusiness.Text),_ProductInfo.getId());             
                MessageBox.Show("Update  Row");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            addProductlist_item_to_txtbox(listBoxProduct.Text);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(txtNameProduct.Text !="" && txtMakat.Text !="" && txtPrice.Text !="" && txtCamot.Text !="" )
                insertNewProduct();
            else
                MessageBox.Show("הנתונים שהוזנו שגואים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            insertNewCategory();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            DeleteCategory();
        }

        private void txtNameProduct_TextChanged(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < txtNameProduct.Text.Length; i++)
            {
                if (txtNameProduct.Text[i] >= '0' && txtNameProduct.Text[i] <= '9')
                    c++;
            }
            if (c > 0)
            {
                MessageBox.Show("הנתונים שהוזנו שגואים", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameProduct.Text = "";
            }
                
        }

        private void btnAllProduct_Click(object sender, EventArgs e)
        {
            Showproduct();
        }

        private void btnProductCamotLow_Click(object sender, EventArgs e)
        {
            showListProductCamotLow();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = "";
            for (int i = 0; i < _listObjectProduct.Count; i++)
            {
                if (txtSearch.Text == _listObjectProduct[i].getMakat())
                {

                    //str = string.Format("{0,-3}{1,5}{2,20}{3,6} {4,8:#.00}", _ListObjectforSearch[i].getId(), _ListObjectforSearch[i].getMakat(), _ListObjectforSearch[i].getName(), _ListObjectforSearch[i].getQuantity(), _ListObjectforSearch[i].getPrice());
                    str = string.Format("{0,-3}{1,5}{2,20}{3,6}{4,8:#.00}{5,8:#.00}", _listObjectProduct[i].getId(), _listObjectProduct[i].getMakat(), _listObjectProduct[i].getName(), _listObjectProduct[i].getQuantity(), _listObjectProduct[i].getPrice(), _listObjectProduct[i].getPriceForBusiness());
                }

            }
            if (str != "")
            {
                listBoxProduct.Items.Clear();
                listBoxProduct.Items.Add(str);
            }

            else
                MessageBox.Show("לא נמצא מוצר", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
