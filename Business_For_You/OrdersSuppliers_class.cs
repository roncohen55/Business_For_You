using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_For_You
{
    class OrdersSuppliers_class:Category
    {

        private string _NameSalsmen;

        private string _Details;

        private string _Date;

        private float _Price;

        private List<string> _allSuppliers = new List<string>();

        private List<OrdersSuppliers_class> _allSuppliersObject = new List<OrdersSuppliers_class>();

        public OrdersSuppliers_class() { }

        public OrdersSuppliers_class(int id , string name , string nameSalesmen , string info , float price , string date):base(id,name)
        {
            _NameSalsmen = nameSalesmen;
            _Details = info;
            _Price = price;
            _Date = date;
        }

        public string getNameSalesman() => _NameSalsmen;

        public string getDetails() => _Details;

        public string getDate() => _Date;

        public float getPrice() => _Price;

        public override void giveMeListObject(string str)
        {
            int cObject = 0;
            OrdersSuppliers_class s1;
            string name = "", id = "", nameSalesmen = "", details = "", price = "", date = "";
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
                    nameSalesmen += str[i];
                else if (cObject == 3)
                    details += str[i];
                else if (cObject == 4)
                    price += str[i];
                else if (cObject == 5)
                    date += str[i];
               




            }

            s1 = new OrdersSuppliers_class (int.Parse(id.Trim()), name.Trim(), nameSalesmen.Trim(), details.Trim(),float.Parse( price.ToString().Trim()), date.Trim());


            _allSuppliersObject.Add(s1);


        }

        public override void funcToHelpList(List<string> arr)
        {

            for (int j = 0; j < arr.Count; j++)
                giveMeListObject(arr[j]);

        }

        //show suppliersOrder from sql
        public override List<string> ShowList()
        {

            _allSuppliers.Clear();
            _allSuppliersObject.Clear();

            string str = "";
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("H#");
            funcToHelpList(arr);

            for (int i = 0; i < _allSuppliersObject.Count; i++)
            {
                str = _allSuppliersObject[i].getId() + "   " + _allSuppliersObject[i].getName() + "   " + _allSuppliersObject[i].getDate();
                _allSuppliers.Add(str);
            }

            return _allSuppliers;


        }

        public List<OrdersSuppliers_class> ShowListObject()
        {

           
            _allSuppliersObject.Clear();
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("H#");
            funcToHelpList(arr);

           

            return _allSuppliersObject;


        }

        public OrdersSuppliers_class ShowinfoFromdata(string Rew)
        {

            OrdersSuppliers_class tmp1 = new OrdersSuppliers_class();

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
            pac = "K#" + id;
            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);

        }

        public void insertNewSuppliersOrder(string Name, string NameSalesmen, string details, float price, string date)
        {
            int id = 0;

            string str = "", s = "";

            str = id + " ~ " + Name + " ~ " + NameSalesmen + " ~ " + details + " ~ " + price + " ~ " + date;

            string pac = "J#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);
        }

        public Suppliers_Class GiveMeSuppliersEmailAndPhone(string str)
        {
            Suppliers_Class s1 = new Suppliers_Class();
            List<Suppliers_Class> listTosearch = new List<Suppliers_Class>();
            listTosearch = s1.ShowListObject();
            string[] tmp = str.Split(',');
            for(int i =0; i<listTosearch.Count; i++)
            {
                if (listTosearch[i].getName().Trim() == tmp[0].Trim() && listTosearch[i].getCompany().Trim() == tmp[1].Trim())
                    s1 = listTosearch[i];
            }
            return s1;
        }
    }
}
