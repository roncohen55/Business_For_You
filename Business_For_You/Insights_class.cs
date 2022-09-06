using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_For_You
{
    class Insights_class:Category
    {
        private string _Note;

        private int _Rating;

        private string _Date;

        private List<string> _allInsights = new List<string>();

        private List<Insights_class> _allInsightsObject = new List<Insights_class>();

        public Insights_class() { }

        public Insights_class(int id, string name, string note , int rating , string date) : base(id, name)
        {
            _Note = note;
            _Rating = rating;
            _Date = date;
        }

        public string getNote() => _Note;

        public int getRating() => _Rating;

        public string getDate() => _Date;

        public override void giveMeListObject(string str)
        {
            int cObject = 0;
            Insights_class i1;
            string name = "", id = "" , note="" , ratin="",date="";
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
                    note += str[i];
                else if (cObject == 3)
                    ratin += str[i];
                else if (cObject == 4)
                    date += str[i];





            }

            i1 = new Insights_class(int.Parse(id.Trim()), name.Trim() , note.Trim(),int.Parse(ratin) , date.Trim());
           _allInsightsObject.Add(i1);


        }
        //show data from sql
        public override List<string> ShowList()
        {

            _allInsights.Clear();
            _allInsightsObject.Clear();

            string str = "";
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer("A#");
            funcToHelpList(arr);

            for (int i = 0; i < _allInsightsObject.Count; i++)
            {
                str = _allInsightsObject[i].getId() + "   " + _allInsightsObject[i].getName() + "   " + _allInsightsObject[i].getNote() + "   " + _allInsightsObject[i].getRating() + "   " + _allInsightsObject[i].getDate();
                _allInsights.Add(str);
            }



            return _allInsights;


        }


        public virtual List<string> ShowListForSalesman(string nameUser)
        {



            _allInsights.Clear();
            _allInsightsObject.Clear();

            string str = "", pac = "";
            pac = "E#" + nameUser.Trim();
            List<string> arr = new List<string>();
            funcServer f1 = new funcServer();
            arr = f1.dataFromServer(pac);
            funcToHelpList(arr);

            for (int i = 0; i < _allInsightsObject.Count; i++)
            {
                str = _allInsightsObject[i].getId() + "   " + _allInsightsObject[i].getName() + "   " + _allInsightsObject[i].getNote() + "   " + _allInsightsObject[i].getRating() + "   " + _allInsightsObject[i].getDate();
                _allInsights.Add(str);
            }



            return _allInsights;


        }

        public Insights_class ShowinfoFromdata(string Rew)
        {

            Insights_class tmp1 = new Insights_class();

            int id = ShowIdfromList(Rew);

            for (int i = 0; i < _allInsightsObject.Count; i++)
            {
                if (id == _allInsightsObject[i].getId())
                    tmp1 = _allInsightsObject[i];
            }


            return tmp1;

        }

        public override void funcToHelpList(List<string> arr)
        {

            for (int j = 0; j < arr.Count; j++)
                giveMeListObject(arr[j]);

        }

        public override void Delete(string Rew)
        {
            string s = "", pac = "";

            int id;
            id = ShowIdfromList(Rew);
            pac = "C#" + id;
            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);



        }


        public void Insert(string name , string note , int rating)
        {
            int id = 0;
            string str = "", s = "";

            str = id + " ~ " + name + " ~ " + note + " ~ " +rating;

            string pac = "D#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);
        }

        public void Update(int id, string name , string note , int rating)
        {
            string str = "", s = "";

            str = id + " ~ " + name + " ~ " + note + " ~ " +rating;

            string pac = "B#" + str;

            funcServer f1 = new funcServer();
            s = f1.dataStringFromServer(pac);



        }

    }
}
