using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_For_You
{
    class Products_class:Category
    {
        private string _Makat;

        private int _Quantity;

        private int _Type;

        private float _Price;

        private float _PriceForTheBusiness;

        private List<string> _allProducts = new List<string>();

        private List<Products_class> _allProductsObject = new List<Products_class>();

        private List<Products_class> _allProductsObjectforTypeCategory = new List<Products_class>();

        public Products_class() { }

        public Products_class(int id, string makat, string name, int quantity, int type, float price, float priceforthebusiness) : base(id, name)
        {
            _Makat = makat;

            _Quantity = quantity;

            _Type = type;

            _Price = price;

            _PriceForTheBusiness = priceforthebusiness;
        }

        public string getMakat() => _Makat;

        public int getQuantity() => _Quantity;

        public int getType() => _Type;

        public float getPrice() => _Price;

        public float getPriceForBusiness() => _PriceForTheBusiness;

        public override void giveMeListObject(string str)
        {
            int cObject = 0;
     
            Products_class p1;
            string name = "", id = "", makat = "", quantity = "", type = "", price = "", priceforthebusiness = "";
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == '~')
                {
                    cObject++;


                }

                else if (cObject == 0 && str[i] >= '0' && str[i] <= '9')
                    id += str[i];
                else if (cObject == 1)
                    makat += str[i];
                else if (cObject == 2)
                    name += str[i];
                else if (cObject == 3)
                    quantity += str[i];
                else if (cObject == 4)
                    type += str[i];
                else if (cObject == 5)
                    price += str[i];
                else if (cObject == 6)
                    priceforthebusiness += str[i];




            }

            p1 = new Products_class(int.Parse(id.Trim()), makat.Trim(), name.Trim(), int.Parse(quantity.Trim()), int.Parse(type.Trim()), float.Parse(price.Trim()), float.Parse(priceforthebusiness.Trim()));

            _allProductsObject.Add(p1);


        }
        //show products from sql
        public override List<string> ShowList()
        {

            _allProducts.Clear();
            _allProductsObject.Clear();

            string str = "";
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("r#111");
            funcToHelpList(arr);

            for (int i = 0; i < _allProductsObject.Count; i++)
            {
                string s = "";
                // str = string.Format("{0,-3}{1,5}{2,20}{3,6}{4,8:#.00}{5,8:#.00}",_allProductsObject[i].getId(), _allProductsObject[i].getMakat(), _allProductsObject[i].getName(), _allProductsObject[i].getQuantity(), _allProductsObject[i].getPrice(), _allProductsObject[i].getPriceForBusiness());
                if (_allProductsObject[i].getName().Length <= 17)
                {
                   
                    int num = 16 - _allProductsObject[i].getName().Length;
                    for (int j = 0; j <= num; j++)
                        s += " ";
                        
                }
                str = string.Format("{0,-3}{1,5}{2,20}{3}{4,6}{5,8:#.00}{6,8:#.00}", _allProductsObject[i].getId(), _allProductsObject[i].getMakat(), _allProductsObject[i].getName(), s,_allProductsObject[i].getQuantity(), _allProductsObject[i].getPrice(), _allProductsObject[i].getPriceForBusiness());
                _allProducts.Add(str);
            }



            return _allProducts;


        }

        public List<string> ShowListProductCamotLow()
        {

            _allProducts.Clear();
            _allProductsObject.Clear();

            string str = "";
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("r#111");
            funcToHelpList(arr);

            for (int i = 0; i < _allProductsObject.Count; i++)
            {
                if (_allProductsObject[i].getQuantity() < 10)
                {
                    string s = "";
                    // str = string.Format("{0,-3}{1,5}{2,20}{3,6}{4,8:#.00}{5,8:#.00}",_allProductsObject[i].getId(), _allProductsObject[i].getMakat(), _allProductsObject[i].getName(), _allProductsObject[i].getQuantity(), _allProductsObject[i].getPrice(), _allProductsObject[i].getPriceForBusiness());
                    if (_allProductsObject[i].getName().Length <= 17)
                    {

                        int num = 16 - _allProductsObject[i].getName().Length;
                        for (int j = 0; j <= num; j++)
                            s += " ";

                    }
                    str = string.Format("{0,-3}{1,5}{2,20}{3}{4,6}{5,8:#.00}{6,8:#.00}", _allProductsObject[i].getId(), _allProductsObject[i].getMakat(), _allProductsObject[i].getName(), s, _allProductsObject[i].getQuantity(), _allProductsObject[i].getPrice(), _allProductsObject[i].getPriceForBusiness());
                    _allProducts.Add(str);
                }
             
            }



            return _allProducts;


        }


        //show products Listobject from sql
        public List<Products_class> ShowListObject()
        {

            
            _allProductsObject.Clear();

            
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("r#111");
            funcToHelpList(arr);
            return _allProductsObject;


        }

        public override void funcToHelpList(List<string> arr)
        {

            for (int j = 0; j < arr.Count; j++)
                giveMeListObject(arr[j]);

        }

        public List<string> ShowListProductForCategory(int type)
        {
            _allProducts.Clear();
            _allProductsObject.Clear();

            string str = "" , pac="";
            pac = "F#" + type;
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer(pac);
            funcToHelpList(arr);

            for (int i = 0; i < _allProductsObject.Count; i++)
            {
                //str = _allProductsObject[i].getMakat() + "   " + _allProductsObject[i].getName() + "   " + _allProductsObject[i].getQuantity() + "   " + _allProductsObject[i].getPrice();
                str = string.Format("{0,-3}{1,20}{2,6}{3,8:#.00}",_allProductsObject[i].getMakat(), _allProductsObject[i].getName(), _allProductsObject[i].getQuantity(), _allProductsObject[i].getPrice());
                _allProducts.Add(str);
            }


            return _allProducts;

        }

     

        public Products_class ShowinfoFromdata(string Rew)
        {

            Products_class tmp1 = new Products_class();

            int id = ShowIdfromList(Rew);

            for (int i = 0; i < _allProductsObject.Count; i++)
            {
                if (id == _allProductsObject[i].getId())
                    tmp1 = _allProductsObject[i];
            }



            return tmp1;

        }

        public override void Delete(string Rew)
        {
            string s = "", pac = "";

            int id;
            id = ShowIdfromList(Rew);
            pac = "t#" + id;
            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);



        }

        public void Insert(string makat, string Name, int quantity,  float price, int type, float priceForBIsnuss)
        {
            int id = 0;
            string str = "", s = "";

            str = id + " ~ " + makat + " ~ " + Name + " ~ " + quantity + " ~ " + type + " ~ " + price + " ~ " + priceForBIsnuss;

            string pac = "u#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);


         
        }

        public void Update(string makat, string Name, int quantity, float price, int type, float priceForBIsnuss, int id)
        {
            string str = "", s = "";

            str = id + " ~ " + makat + " ~ " + Name + " ~ " + quantity + " ~ " + type + " ~ " + price + " ~ " + priceForBIsnuss;

            string pac = "s#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);



        }

        // func for new order form

        //show products from sql for new order
        public List<string> ShowListNewOrder()
        {

            _allProducts.Clear();
            _allProductsObject.Clear();

            string str = "";
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("r#111");
            funcToHelpList(arr);

            for (int i = 0; i < _allProductsObject.Count; i++)
            {
                string s = "";
                // str = _allProductsObject[i].getMakat() + "   " + _allProductsObject[i].getName() + "   " + _allProductsObject[i].getQuantity() + "   " + _allProductsObject[i].getPrice();
                if (_allProductsObject[i].getName().Length <= 17)
                {

                    int num = 16 - _allProductsObject[i].getName().Length;
                    for (int j = 0; j <= num; j++)
                        s += " ";

                }
                str = string.Format("{0,-3}{1,5}{2,20}{3}{4,6} {5,8:#.00}", _allProductsObject[i].getId(), _allProductsObject[i].getMakat(), _allProductsObject[i].getName(),s,_allProductsObject[i].getQuantity(), _allProductsObject[i].getPrice());
                _allProducts.Add(str);
            }



            return _allProducts;


        }


    }
}
