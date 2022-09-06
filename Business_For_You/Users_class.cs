using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_For_You
{
    class Users_class:Category
    {
        private string _Password;

        private int _Chack;

        private List<Users_class> _allUsersObject = new List<Users_class>();

        public Users_class() { }

        public Users_class(int id , string name ,string pass , int chack) : base(id, name)
        {
            _Password = pass;

            _Chack = chack;
        }

        public string getPassword() => _Password;

        public int getChack() => _Chack;

        public override void giveMeListObject(string str)
        {
            int cObject = 0;
            Users_class u1;
            string name = "", id = "" , pass="" , chack="";
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
                    pass += str[i];
                else if (cObject == 3)
                    chack += str[i];





            }

            u1 = new Users_class(int.Parse(id.Trim()), name.Trim() , pass.Trim() , int.Parse(chack.Trim()));
            _allUsersObject.Add(u1);


        }
        //show data from sql
        public  List<Users_class> ShowListObject()
        {

            _allUsersObject.Clear();

            string str = "";
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("j#");
            funcToHelpList(arr);

         



            return _allUsersObject;


        }

        public override void funcToHelpList(List<string> arr)
        {

            for (int j = 0; j < arr.Count; j++)
                giveMeListObject(arr[j]);

        }

        public Users_class ShowinfoFromdata(string Rew)
        {

            Users_class tmp1 = new  Users_class();

            int id = ShowIdfromList(Rew);

            for (int i = 0; i < _allUsersObject.Count; i++)
            {
                if (id == _allUsersObject[i].getId())
                    tmp1 = _allUsersObject[i];
            }


            return tmp1;

        }

        public override void Delete(string Rew)
        {
            string s = "", pac = "";

            int id;
            id = ShowIdfromList(Rew);
            pac = "l#" + id;
            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);



        }

        public void Insert(string name ,string pass , int check)
        {
            int id = 0;
            string str = "", s = "";

            str = id + " ~ " + name + " ~ " + pass + " ~ " +check;

            string pac = "m#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);
        }

        public void Update(int id, string name, string pass, int check)
        {
            string str = "", s = "";

            str = id + " ~ " + name + " ~ " + pass + " ~ " + check;

            string pac = "k#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);



        }


    }
}
