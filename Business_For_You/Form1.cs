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
    public partial class Form1 : Form
    {
        private Users_class tmp = new Users_class();

        private List<Users_class> _allUsersObject = new List<Users_class>();

        public Form1()
        {
            InitializeComponent();
            
           
          
        }
    
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {         
            try
            {
                _allUsersObject.Clear();
                string str = "";
                int c = 0,cBdikamang=0;
                _allUsersObject = tmp.ShowListObject();

                for (int i=0; i<_allUsersObject.Count; i++) 
                {


                    if (txtNameuser.Text == _allUsersObject[i].getName() && txtPassword.Text == _allUsersObject[i].getPassword() && _allUsersObject[i].getChack().ToString() == "1")
                    {
                        str = txtNameuser.Text;
                        c += 1;
                        cBdikamang += 1;
                    }

                    if (txtNameuser.Text == _allUsersObject[i].getName() && txtPassword.Text == _allUsersObject[i].getPassword() && _allUsersObject[i].getChack().ToString() == "0")
                    {
                        str = txtNameuser.Text;
                        c += 1;
                        cBdikamang = 0;
                    }

                }

                if (c == 0)
                    MessageBox.Show("The User or password is not correct", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (c == 1)
                {
                    txtNameuser.Visible = false;
                    txtPassword.Visible = false;
                    label2.Visible = false;
                   
                    label4.Visible = false;
                    btnlogin.Visible = false;
                    panelVi.Visible = true;
                    Dashboard_Salesman d1 = new Dashboard_Salesman(str, cBdikamang);
                    d1.ShowDialog();


                }

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
