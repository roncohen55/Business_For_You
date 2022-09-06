using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Business_For_You
{
    class Bids_class:Category
    {
 

        private string _info;

        private string _quantityInfo;

        private float _price;

      

        private string _phone;

        private string _address;

        private string _Note;

        private string _date;

        private string _email;

        private string _salesman;

        private List<string> _allBids = new List<string>();

        private List<Bids_class> _allBidsObject = new List<Bids_class>();


        public Bids_class() { }

        public Bids_class(int id , string info , string quantity , float price , string name , string phone , string address, string note , string date , string email , string salesman):base(id,name)
        {
    
            _info = info;
            _quantityInfo = quantity;
            _price = price;
          
            _phone = phone;
            _address = address;
            _Note = note;
            _date = date;
            _email = email;
            _salesman = salesman;
        }

  

        public string getInfo() => _info;

        public string getQuantityInfo() => _quantityInfo;

        public float getPrice() => _price;


        public string getPhone() => _phone;

        public string getAddress() => _address;

        public string getNote() => _Note;

        public string getDate() => _date;

        public string getEmail() => _email;

        public string getSalesman() => _salesman;

        //

        //help me cut and object
        public override void giveMeListObject(string str)
        {
            int cObject = 0 ;
            
            string info="" , quantity="" , name="" , phone="" , address="" , note="" , date="" , email="", salesman="",id="", price = "";
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
                    phone += str[i];
                else if (cObject == 7)
                    address += str[i];
                else if (cObject == 8)
                    note += str[i];
                else if (cObject == 9)
                    date += str[i];
                else if (cObject == 10)
                    email += str[i];
                
              


            }

            Bids_class b1 = new Bids_class(int.Parse( id), info, quantity, float.Parse(price.ToString()), name, phone, address, note, date, email, salesman);
            _allBidsObject.Add(b1);

         ;
        }
        //show bids from sql
        public override List<string> ShowList()
        {

            _allBids.Clear();
            _allBidsObject.Clear();

            string str = "";
            List<string> arr = new List<string>();
        funcServer f1 = new funcServer();
           arr = f1.dataFromServer("a#111");
            funcToHelpList(arr);

            for(int i=0; i<_allBidsObject.Count; i++)
            {
                str = _allBidsObject[i].getId() + "   " + _allBidsObject[i].getName() + "   " + _allBidsObject[i].getPhone() + _allBidsObject[i].getAddress() + "  " + _allBidsObject[i].getDate() ;
                _allBids.Add(str);
            }

            

            return _allBids;


        }

        public List<Bids_class> ShowListObject()
        {
            _allBidsObject.Clear();

            string str = "";
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("a#111");
            funcToHelpList(arr);          
            return _allBidsObject;


        }

        public override void funcToHelpList(List<string>arr)
        {

            for (int j = 0; j < arr.Count; j++)
                giveMeListObject(arr[j]);

        }

        public virtual List<string> ShowListForSalesman(string nameUser)
        {

          

            _allBids.Clear();
            _allBidsObject.Clear();

            string str = "",pac="";
            pac = "e#" + nameUser.Trim();
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer(pac);
            funcToHelpList(arr);

            for (int i = 0; i < _allBidsObject.Count; i++)
            {
                //str = _allBidsObject[i].getId() + "   " + _allBidsObject[i].getName() + "   " + _allBidsObject[i].getPhone() + _allBidsObject[i].getAddress() + "  " + _allBidsObject[i].getDate();
                str = string.Format("{0,-3}{1,10}{2,10:#.00} {3,12}", _allBidsObject[i].getId(), _allBidsObject[i].getName(), _allBidsObject[i].getPrice(), _allBidsObject[i].getDate());
                _allBids.Add(str);
            }



            return _allBids;


        }


        public Bids_class ShowinfoFromdata(string Rew)
        {

           Bids_class tmp1 = new Bids_class();

                  int id = ShowIdfromList(Rew);
        
            for(int i= 0; i < _allBidsObject.Count; i++)
            {
                if (id == _allBidsObject[i].getId())
                    tmp1 = _allBidsObject[i];
            }


           


            return tmp1;
            
        }

        public override void Delete(string Rew)
        {
            string s="", pac="";
           
                int id;
                id = ShowIdfromList(Rew);
                pac = "c#" + id;
                funcServer f1 = new funcServer();
                s = f1.dataStringFromServer(pac);
             
        
            
        }

        public void Insert(string info, string quantity, float price, string Name, string phone, string address, string note, string email, string nameUs)
        {
            int id = 0;
            string str = "", s = "";

            str = id + " ~ " + info + " ~ " + quantity + " ~ " + price + " ~ " + Name + " ~ " + phone + " ~ " + address + " ~ " + note + " ~ " + email + " ~ " + nameUs;

            string pac = "d#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);
        }

        public void UpdateBid(string info, string quantity , float price, string Name, string phone, string address, string note, string email, int id)
        {
            string str="",s="";

            str = id + " ~ " + info + " ~ " + quantity+" ~ " + price + " ~ " + Name + " ~ " + phone + " ~ " + address + " ~ " + note + " ~ " + email  ;

            string pac = "b#" + str;

            funcServer f1 = new funcServer();
             s = f1.dataStringFromServer(pac);

       



           
            
        }
    }
}
