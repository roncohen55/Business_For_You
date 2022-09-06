using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_For_You
{
    class Sales_class:Bids_class
    {
        private float _PriceForTheBusiness;

        private List<string> _allSales = new List<string>();

        private List<Sales_class> _allSalesObject = new List<Sales_class>();

        public Sales_class() { }

        public Sales_class(int id, string info, string quantity, float price, string salesman, string name, string note, string phone, string address, string date, string email, float priceforthebusiness) : base(id, info, quantity, price, name, phone, address, note, date, email, salesman)
        {
            _PriceForTheBusiness = priceforthebusiness;
        }

        public float getPriceForBusiness() => _PriceForTheBusiness;

        //help me
        public override void giveMeListObject(string str)
        {

            int cObject = 0;
            Sales_class s1;
            string info = "", quantity = "", name = "", phone = "", address = "", note = "", date = "", email = "", salesman = "", id = "", price = "", priceforthebusiness = "";
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == '~')
                {
                    cObject++;


                }

                else if (cObject == 0 && str[i] >= '0' && str[i] <= '9')
                    id += str[i];
                else if (cObject == 1)
                    info += str[i];
                else if (cObject == 2)
                    quantity += str[i];
                else if (cObject == 3)
                    price += str[i];
                else if (cObject == 4)
                    salesman += str[i];
                else if (cObject == 5)
                    name += str[i];
                else if (cObject == 6)
                    note += str[i];
                else if (cObject == 7)
                    phone += str[i];
                else if (cObject == 8)
                    address += str[i];
                else if (cObject == 9)
                    date += str[i];
                else if (cObject == 10)
                    email += str[i];
                else if (cObject == 11)
                    priceforthebusiness += str[i];
            }

            s1 = new Sales_class(int.Parse(id.Trim()), info.Trim(), quantity.Trim(), float.Parse(price.ToString().Trim()), salesman.Trim(), name.Trim(), note.Trim(), phone.Trim(), address.Trim(), date.Trim(), email.Trim(), float.Parse(priceforthebusiness.ToString().Trim()));

            _allSalesObject.Add(s1);

            
        }
        //show sale from sql
        public override List<string> ShowList()
        {

           _allSales.Clear();
            _allSalesObject.Clear();

            string str = "";
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("v#111");
            funcToHelpList(arr);

            for (int i = 0; i < _allSalesObject.Count; i++)
            {
                //str = _allSalesObject[i].getId() + "   " + _allSalesObject[i].getName() + "  " + _allSalesObject[i].getDate();
                str = string.Format("{0,-3}{1,10}{2,10:#.00} {3,12}", _allSalesObject[i].getId(), _allSalesObject[i].getName(), _allSalesObject[i].getPrice(), _allSalesObject[i].getDate());
                _allSales.Add(str);
            }



            return _allSales;


        }

        //show list object for statistic
        public  List<Sales_class> ShowListObject()
        {

           
            _allSalesObject.Clear();

           
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("v#111");
            funcToHelpList(arr);

          



            return _allSalesObject;


        }

        public override void funcToHelpList(List<string> arr)
        {

            for (int j = 0; j < arr.Count; j++)
                giveMeListObject(arr[j]);

        }

        public override List<string> ShowListForSalesman(string nameUser)
        {



            _allSales.Clear();
            _allSalesObject.Clear();

            string str = "", pac = "";
            pac = "z#" + nameUser.Trim();
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer(pac);
            funcToHelpList(arr);

            for (int i = 0; i < _allSalesObject.Count; i++)
            {
               str = string.Format("{0,-3}{1,10}{2,10:#.00} {3,12}", _allSalesObject[i].getId(), _allSalesObject[i].getName(), _allSalesObject[i].getPrice(), _allSalesObject[i].getDate());
                _allSales.Add(str);
            }

            return _allSales;

        }

        //show list object for salesman for statistic
        public List<Sales_class> ShowListObjectForSalesman(string nameUser)
        {

        
            _allSalesObject.Clear();

            string  pac = "";
            pac = "z#" + nameUser.Trim();
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer(pac);
            funcToHelpList(arr);

           

            return _allSalesObject;

        }

        public Sales_class ShowinfoFromdata(string Rew)
        {

            Sales_class tmp1 = new Sales_class();

            int id = ShowIdfromList(Rew);

            for (int i = 0; i <_allSalesObject.Count; i++)
            {
                if (id == _allSalesObject[i].getId())
                    tmp1 = _allSalesObject[i];
            }

            return tmp1;

        }

        public override void Delete(string Rew)
        {
            string s = "", pac = "";

            int id;
            id = ShowIdfromList(Rew);
            pac = "x#" + id;
            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);



        }

        public void Insert(string info, string quantity, float price, string Name, string phone, string address, string note, string email, string nameUs,  float priceForBisnuss)
        {
            int id = 0;
            string str = "", s = "";

            str = id + " ~ " + info + " ~ " + quantity + " ~ " + price + " ~ " + nameUs + " ~ " + Name + " ~ " + note + " ~ " + phone + " ~ " + address + " ~ " + email + " ~ " + priceForBisnuss;

            string pac = "y#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);


        }

        public void UpdateSale(string info, string quantity, float price, string Name, string phone, string address, string note, string email, int id , float priceForBisnuss)
        {

            string str = "", s = "",nameUs="";

            str = id + " ~ " + info + " ~ " + quantity + " ~ " + price + " ~ " + nameUs + " ~ " + Name + " ~ " + note + " ~ " + phone + " ~ " + address + " ~ " + email + " ~ " + priceForBisnuss;

            string pac = "w#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);

        }

        //func for form contact

     
    }
}
