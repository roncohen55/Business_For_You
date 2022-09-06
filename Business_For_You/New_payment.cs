using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_For_You
{
    class New_payment
    {
      

        private int _id;

        private string _NameProduct;

        private int _Quantity;

        private static int counter = 2;

        private double _Price;

        

        public New_payment(string name_prodect,int quantity,double price)
        {
            _id = counter++;

            _NameProduct = name_prodect;

            _Quantity = quantity;

          _Price = price;
        }


        public int getid() => _id;

        public string getNameProduct() => _NameProduct;

        public int getquantity() => _Quantity;

        public double getPrice() => _Price;


    }
}
