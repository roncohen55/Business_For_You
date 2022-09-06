using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business_For_You
{
    class Suppliers_Class:Category
    {

        private string _Company;

        private string _Details;

        private string _Phone;

        private string _Email;

        private int _Rating;

        private List<string> _allSuppliers = new List<string>();

        private List<Suppliers_Class> _allSuppliersObject = new List<Suppliers_Class>();

        public Suppliers_Class()
        {

        }

        public Suppliers_Class(int id , string name , string company , string details , string phone , string email , int rating):base(id,name)
        {
       
            _Company = company;

            _Details = details;

            _Phone = phone;

            _Email = email;

            _Rating = rating;
        }

        public string getCompany() => _Company;

        public string getDetails() => _Details;

        public string getPhone() => _Phone;

        public string getEmail() => _Email;

        public int getRating() => _Rating;

        public override void giveMeListObject(string str)
        {
            int cObject = 0;
            Suppliers_Class s1;
            string name = "", id = "", company = "", details = "", phone = "", email = "", rating = "";
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == '~')
                {
                    cObject++;


                }

                else if (cObject == 0 && str[i] >= '0' && str[i] <= '9')
                    id += str[i];
                else if (cObject == 1)
                    name += str[i];
                else if (cObject == 2)
                    company += str[i];
                else if (cObject == 3)
                    details += str[i];
                else if (cObject == 4)
                    phone += str[i];
                else if (cObject == 5)
                    email += str[i];
                else if (cObject == 6)
                    rating += str[i];




            }

            s1 = new Suppliers_Class(int.Parse(id.Trim()), name.Trim(), company.Trim(), details.Trim(), phone.Trim(), email.Trim(), int.Parse(rating.Trim()));

          
            _allSuppliersObject.Add(s1);


        }

        public override void funcToHelpList(List<string> arr)
        {

            for (int j = 0; j < arr.Count; j++)
                giveMeListObject(arr[j]);

        }

        //show suppliers from sql
        public override List<string> ShowList()
        {

           _allSuppliers.Clear();
            _allSuppliersObject.Clear();

            string str = "";
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("n#");
            funcToHelpList(arr);

            for (int i = 0; i < _allSuppliersObject.Count; i++)
            {
                str = _allSuppliersObject[i].getId() + "   " + _allSuppliersObject[i].getName() + "   " + _allSuppliersObject[i].getCompany();
                _allSuppliers.Add(str);
            }

            return _allSuppliers;


        }

        //show list object for form contact
        public  List<Suppliers_Class> ShowListObject()
        {

            
            _allSuppliersObject.Clear();

           
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("n#");
            funcToHelpList(arr);          

            return _allSuppliersObject;


        }


        public Suppliers_Class ShowinfoFromdata(string Rew)
        {

            Suppliers_Class tmp1 = new Suppliers_Class();

            int id = ShowIdfromList(Rew);

            for (int i = 0; i < _allSuppliersObject.Count; i++)
            {
                if (id == _allSuppliersObject[i].getId())
                    tmp1 = _allSuppliersObject[i];
            }


            return tmp1;

        }


        public override void Delete(string Rew)
        {
            string s = "", pac = "";

            int id;
            id = ShowIdfromList(Rew);
            pac = "p#" + id;
            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);

        }

        public void UpdateSuppliers(string Name, string company, string details, string phone, string email,int rating, int id)
        {

            string str = "", s = "";

            str = id + " ~ " + Name + " ~ " + company + " ~ " + details + " ~ " + phone + " ~ " + email + " ~ " + rating;

            string pac = "o#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);


        }

        public void insertNewSuppliers(string Name, string company, string details, string phone, string email, int rating)
        {          
            int id = 0;

            string str = "", s = "";

            str = id + " ~ " + Name + " ~ " + company + " ~ " + details + " ~ " + phone + " ~ " + email + " ~ " + rating;

            string pac = "q#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);
        }
    }
}
