using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_For_You
{
    class Category
    {
        private int _id;

        private string _Name;

        private List<string> _allCategory = new List<string>();

        private List<Category> _allCategoryObject = new List<Category>();

        public Category() { }

        public Category(int id, string name)
        {
            _id = id;
            _Name = name;
        }

        public int getId() => _id;

        public string getName() => _Name;

        //help me
        public virtual void giveMeListObject(string str)
        {
            int cObject = 0;
            Category c1;
            string name = "", id = "";
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





            }

            c1 = new Category(int.Parse(id.Trim()), name.Trim());
            _allCategoryObject.Add(c1);

  
        }
        //show data from sql
        public virtual List<string> ShowList()
        {

            _allCategory.Clear();
            _allCategoryObject.Clear();

            string str = "";
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("f#");
            funcToHelpList(arr);

            for (int i = 0; i < _allCategoryObject.Count; i++)
            {
                str = _allCategoryObject[i].getId() + "   " + _allCategoryObject[i].getName();
                _allCategory.Add(str);
            }



            return _allCategory;


        }


        //show data from sql
        public virtual List<string> ShowListforBtnMenu()
        {

            _allCategory.Clear();
            _allCategoryObject.Clear();

            string str = "";
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("f#");
            funcToHelpList(arr);

            for (int i = 0; i < _allCategoryObject.Count; i++)
            {
                str = _allCategoryObject[i].getName();
                _allCategory.Add(str);
            }



            return _allCategory;


        }

        public virtual void funcToHelpList(List<string> arr)
        {

            for (int j = 0; j < arr.Count; j++)
                giveMeListObject(arr[j]);

        }

        public int ShowIdfromList(string str)
        {
            string strid = "";
            int c = 0, id = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    c++;
                if (c == 0)
                    strid += str[i];
            }

            id = int.Parse(strid);
            return id;
        }

        public virtual void Delete(string Rew)
        {
            string s = "", pac = "";

            int id;
            id = ShowIdfromList(Rew);
            pac = "h#" + id;
            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);



        }


        public void Insert( string name)
        {
            int id = 0;
            string str = "", s = "";

            str = id + " ~ " + name;

            string pac = "i#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);
        }

        public  void Update(int id,string name)
        {
            string str = "", s = "";

            str = id + " ~ " + name;

            string pac = "g#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);



        }

    }
}
