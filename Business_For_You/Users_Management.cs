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
    public partial class Users_Management : Form
    {
        private Users_class tmp = new Users_class();

        private Users_class _UserInfo;

        private List<Users_class> _allUsersObject = new List<Users_class>();

        public Users_Management()
        {
            InitializeComponent();
            ShowUsers();
        }

        private void ShowUsers()
        {
            try
            {
                string str;
                
                _allUsersObject.Clear();

                _allUsersObject = tmp.ShowListObject();

                for(int i=0; i < _allUsersObject.Count; i++)
                {
                    if(_allUsersObject[i].getChack() == 0)
                    str = _allUsersObject[i].getId() + "  " + _allUsersObject[i].getName() + " " + "עובד";
                    else
                        str = _allUsersObject[i].getId() + "  " + _allUsersObject[i].getName() + " " + "מנהל";
                    listBox1.Items.Add(str);
                }


            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int checkTXT( string check)
        {
            int result = 0;
            for(int i=0; i < check.Length; i++)
            {
                if (check[i] >= '0' && check[i] <= '9')
                    result += 0;
                else
                    result += 1;
            }
            return result;
        }

        private void ShowinfoFromdata()
        {
            try
            {

                _UserInfo = tmp.ShowinfoFromdata(listBox1.Text);
                txtName.Text = _UserInfo.getName();
                txtPassword.Text = _UserInfo.getPassword();
                txtCheck.Text = _UserInfo.getChack().ToString();

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUser()
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

        private void insertNewUser()
        {
            try
            {
                int result = checkTXT(txtCheck.Text);
                if (result == 0)
                {
                    tmp.Insert(txtName.Text,txtPassword.Text,int.Parse(txtCheck.Text));
                    MessageBox.Show("Insert Sucsses");
                }
                else
                    MessageBox.Show("תפקיד העובד חייב להיות מספר,מנהל 1 עובד 0", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUser()
        {
            try
            {
                int result = checkTXT(txtCheck.Text);
                if (result == 0)
                {
                    tmp.Update(_UserInfo.getId(),txtName.Text, txtPassword.Text, int.Parse(txtCheck.Text));
                    MessageBox.Show("Update Sucsses");
                }
                else
                    MessageBox.Show("תפקיד העובד חייב להיות מספר,מנהל 1 עובד 0", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);


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

        private void btninformation_Click(object sender, EventArgs e)
        {
            ShowinfoFromdata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            insertNewUser();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateUser();
        }
    }
}
