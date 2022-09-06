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
    public partial class ProductType_2 : Form
    {
        private Products_class tmp = new Products_class();

        public ProductType_2()
        {
            InitializeComponent();
            ShowproductType2();
        }

        private void ShowproductType2()
        {
            try
            {
                listBox1.Items.Clear();
                List<string> tmp1 = new List<string>();
                tmp1 = tmp.ShowListProductForCategory(2);
                for (int i = 0; i < tmp1.Count; i++)
                    listBox1.Items.Add(tmp1[i]);

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
