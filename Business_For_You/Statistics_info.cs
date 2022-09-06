using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business_For_You
{
    class Statistics_info
    {
        private float _Sales;//מכירות

        private float _Expenses;//הוצאות

        private float _Profit;//רווח

        private int _CountSales;//כמות מכירות

        private List<DateTime> _allMonthYearDate1 = new List<DateTime>();

        private List<string> _allMonthYearDate55 = new List<string>();

        private Statistics_info _StaticInfo1;

        private List<Sales_class> _listSaleObject = new List<Sales_class>();

        private Sales_class _tmpSale = new Sales_class();

        private OrdersSuppliers_class tmpSuppliersOrder = new OrdersSuppliers_class();

        private List<OrdersSuppliers_class> _listOrderSuppliers = new List<OrdersSuppliers_class>();



        public Statistics_info()
        {
           
        }

        public Statistics_info( float sales , float expenses , float profit ,int countSales )
        {
            _Sales = sales;

            _Expenses = expenses;

            _Profit = profit;

            _CountSales = countSales;
        }

        public float getSales() => _Sales;

        public float getExpenses() => _Expenses;

        public float getProfit() => _Profit;

        public int getCountSales() => _CountSales;

      
        // func of date time of stattic day


       private void ganerateDateForDay(DateTime myDate)
        {
          
                int i, c = 0;

                for (i = 0; i < _allMonthYearDate1.Count; i++)
                {
                    if (DateTime.Parse( _allMonthYearDate1[i].ToString()) == myDate)
                        c++;
                }
                if (c == 0)
                    _allMonthYearDate1.Add(myDate);
            
         
        }

        public List<DateTime> ShowDateSalesForDay()
        {

            
            List<DateTime> Date = new List<DateTime>();
            
            Date.Clear();
            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();

          

            for(int j=0; j < _listSaleObject.Count; j++)
            {
                ganerateDateForDay(DateTime.Parse(_listSaleObject[j].getDate().ToString()));
            }

            _listOrderSuppliers.Clear();
            _listOrderSuppliers = tmpSuppliersOrder.ShowListObject();

            for(int z = 0; z < _listOrderSuppliers.Count; z++)
            {
                ganerateDateForDay(DateTime.Parse(_listOrderSuppliers[z].getDate().ToString()));
            }

              for (int i = 0; i < _allMonthYearDate1.Count; i++)
                Date.Add(_allMonthYearDate1[i]);

         

            return Date;

           
        }

        // of year

        public List<string> ShowDateSalesForYear()
        {

            _allMonthYearDate55.Clear();

            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();



            for (int j = 0; j < _listSaleObject.Count; j++)
            {
                ganerateDateForYear(DateTime.Parse(_listSaleObject[j].getDate().ToString()));
            }

            _listOrderSuppliers.Clear();
            _listOrderSuppliers = tmpSuppliersOrder.ShowListObject();

            for (int z = 0; z < _listOrderSuppliers.Count; z++)
            {
                ganerateDateForDay(DateTime.Parse(_listOrderSuppliers[z].getDate().ToString()));
            }

            return _allMonthYearDate55;

          
           
        }
        
        private void ganerateDateForYear(DateTime myDate)
        {

            int i, c = 0;

            for (i = 0; i < _allMonthYearDate55.Count; i++)
            {
                if (_allMonthYearDate55[i].ToString() == myDate.Year.ToString())
                    c++;
            }
            if (c == 0)
                _allMonthYearDate55.Add(myDate.Year.ToString());
        }



        /// of month

        public List<string> ShowDateSalesForMonth()
        {

            _allMonthYearDate55.Clear();

            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();



            for (int j = 0; j < _listSaleObject.Count; j++)
            {
                ganerateDateOfMonth(DateTime.Parse(_listSaleObject[j].getDate().ToString()));
            }

            _listOrderSuppliers.Clear();
            _listOrderSuppliers = tmpSuppliersOrder.ShowListObject();

            for (int z = 0; z < _listOrderSuppliers.Count; z++)
            {
                ganerateDateForDay(DateTime.Parse(_listOrderSuppliers[z].getDate().ToString()));
            }

            return _allMonthYearDate55;
            
           
        }

        private void ganerateDateOfMonth(DateTime myDate)
        {

            int i, c = 0;

            for (i = 0; i < _allMonthYearDate55.Count; i++)
            {
                if (_allMonthYearDate55[i].ToString() == myDate.Month.ToString() + '-' + myDate.Year.ToString())
                    c++;
            }
            if (c == 0)
               _allMonthYearDate55.Add(myDate.Month.ToString() + '-' + myDate.Year.ToString());
        }

        /// 
        //help to show info for year
        private DateTime funchelp(string date)
        {
            DateTime mydate = _allMonthYearDate1[0];
            int i;

            for (i = 0; i < _allMonthYearDate1.Count; i++)
            {
                if (_allMonthYearDate1[i].Year.ToString() == date)
                    mydate = DateTime.Parse( _allMonthYearDate1[i].ToString());
            }
            return mydate;
        }

        //help to show info for month
        private DateTime funchelpMonth(string date)
        {
            DateTime mydate = _allMonthYearDate1[0];
            int i;

            for (i = 0; i < _allMonthYearDate1.Count; i++)
            {
                if (int.Parse( _allMonthYearDate1[i].Month.ToString()) == int.Parse( date))
                    mydate = DateTime.Parse(_allMonthYearDate1[i].ToString());
            }
            return mydate;
        }




        /// day info

        public Statistics_info ShowInfoSalesForDay( string date)
        {
            
            
                DateTime myDate = DateTime.Parse(date);
                float sales = 0, exporer = 0, profit = 0;
                int count = 0;


            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();

            for(int i=0; i < _listSaleObject.Count; i++)
            {
                if (myDate == DateTime.Parse(_listSaleObject[i].getDate().ToString()))
                {

                    count++;


                    sales += float.Parse(_listSaleObject[i].getPrice().ToString());

                    exporer += float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());

                    //profit += float.Parse(_listSaleObject[i].getPrice().ToString()) - float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());


                }
            }

            _listOrderSuppliers.Clear();
            _listOrderSuppliers = tmpSuppliersOrder.ShowListObject();

            for (int z = 0; z < _listOrderSuppliers.Count; z++)
            {
                if (myDate == DateTime.Parse(_listOrderSuppliers[z].getDate().ToString()))
                {
                    exporer += float.Parse(_listOrderSuppliers[z].getPrice().ToString());
                }
            }

            profit = sales - exporer; 



            _StaticInfo1 = new Statistics_info(sales, exporer, profit, count);

            return _StaticInfo1;

              
        }

        //year info

        public Statistics_info ShowInfoSalesForYear(string date)
        {

            DateTime mydate;
            mydate=funchelp(date);
           
            float sales = 0, exporer = 0, profit = 0;
            int count = 0;

            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();

            for (int i = 0; i < _listSaleObject.Count; i++)
            {
                if (mydate.Year == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Year)
                {

                    count++;


                    sales += float.Parse(_listSaleObject[i].getPrice().ToString());

                    exporer += float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());

                   // profit += float.Parse(_listSaleObject[i].getPrice().ToString()) - float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());


                }
            }

            _listOrderSuppliers.Clear();
            _listOrderSuppliers = tmpSuppliersOrder.ShowListObject();

            for (int z = 0; z < _listOrderSuppliers.Count; z++)
            {
                if (mydate.Year == DateTime.Parse(_listOrderSuppliers[z].getDate().ToString()).Year)
                {
                    exporer += float.Parse(_listOrderSuppliers[z].getPrice().ToString());
                }
            }

            profit = sales - exporer;

            _StaticInfo1 = new Statistics_info(sales, exporer, profit, count);

            return _StaticInfo1;


        }

        //info for month
        public Statistics_info ShowInfoSalesForMonth(string date)
        {
            int c = 0;
            string strMonth = "" , strYear="";
            for(int i = 0; i < date.Length; i++)
            {
                if (date[i] == '-')
                    c++;
                if (c == 0)
                    strMonth += date[i];
                else if (c == 1)
                    strYear += date[i];
            }
            
            DateTime mydateMonth;
            mydateMonth = funchelpMonth(strMonth);
            DateTime mydateYear;
            mydateYear = funchelp(strYear.Substring(1));

            float sales = 0, exporer = 0, profit = 0;
            int count = 0;
       
            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();

            for (int i = 0; i < _listSaleObject.Count; i++)
            {
               if (mydateMonth.Month == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Month && mydateYear.Year == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Year)
               {

                    count++;


                    sales += float.Parse(_listSaleObject[i].getPrice().ToString());

                    exporer += float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());

                   // profit += float.Parse(_listSaleObject[i].getPrice().ToString()) - float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());


                }
            }


            _listOrderSuppliers.Clear();
            _listOrderSuppliers = tmpSuppliersOrder.ShowListObject();

            for (int z = 0; z < _listOrderSuppliers.Count; z++)
            {
                if (mydateMonth.Month == DateTime.Parse(_listOrderSuppliers[z].getDate().ToString()).Month && mydateYear.Year == DateTime.Parse(_listOrderSuppliers[z].getDate().ToString()).Year)
                {
                    exporer += float.Parse(_listOrderSuppliers[z].getPrice().ToString());
                }
            }

            profit = sales - exporer;

            _StaticInfo1 = new Statistics_info(sales, exporer, profit, count);

            return _StaticInfo1;


        }

        //func info month for lblmonth in dashboard mange
        public Statistics_info ShowInfoSalesForMonthLbl()
        {
            
            float sales = 0, exporer = 0, profit = 0;
            int count = 0;

            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();

            for (int i = 0; i < _listSaleObject.Count; i++)
            {
                if (DateTime.Now.Month == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Month && DateTime.Now.Year == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Year)
                {

                    count++;


                    sales += float.Parse(_listSaleObject[i].getPrice().ToString());

                    exporer += float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());

                    profit += float.Parse(_listSaleObject[i].getPrice().ToString()) - float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());


                }
            }

            _StaticInfo1 = new Statistics_info(sales, exporer, profit, count);

            return _StaticInfo1;


        }



        private int FuncSize1(float n)
        {
            int size1 = 0;
            if (n > 10000)
                size1 = 350;
            else
            {
                while (n > 0)
                {
                    size1 += 7;
                    n -= 200;
                }
            }
            return size1;
        }

        private int FuncSize(int n)
        {
            int size1 = 0;
            if (n > 10000)
                size1 = 350;
            else
            {
                while (n > 0)
                {
                    size1 += 7;
                    n -= 200;
                }
            }
            return size1;
        }

        public Statistics_info FuncInfoForDiagrm1(float Sales , float exp , float prof , int count)
        {
            Statistics_info tmp = new Statistics_info(FuncSize1(Sales), FuncSize1(exp), FuncSize1(prof), FuncSize(count));


            return tmp;

        }


        //func for statistics _Salesman

        /// day info

        public Statistics_info ShowInfoSalesForDaySalesman(string date , string NameUs)
        {


            DateTime myDate = DateTime.Parse(date);
            float sales = 0, exporer = 0, profit = 0;
            int count = 0;


            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();

            for (int i = 0; i < _listSaleObject.Count; i++)
            {
                if (myDate == DateTime.Parse(_listSaleObject[i].getDate().ToString()) && _listSaleObject[i].getSalesman() == NameUs)
                {

                    count++;


                    sales += float.Parse(_listSaleObject[i].getPrice().ToString());

                    exporer += float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());

                    profit += float.Parse(_listSaleObject[i].getPrice().ToString()) - float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());


                }
            }



            _StaticInfo1 = new Statistics_info(sales, exporer, profit, count);

            return _StaticInfo1;


        }

        //year info

        public Statistics_info ShowInfoSalesForYearSalesman(string date ,string NameUs)
        {

            DateTime mydate;
            mydate = funchelp(date);

            float sales = 0, exporer = 0, profit = 0;
            int count = 0;

            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();

            for (int i = 0; i < _listSaleObject.Count; i++)
            {
                if (mydate.Year == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Year && _listSaleObject[i].getSalesman() == NameUs)
                {

                    count++;


                    sales += float.Parse(_listSaleObject[i].getPrice().ToString());

                    exporer += float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());

                    profit += float.Parse(_listSaleObject[i].getPrice().ToString()) - float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());


                }
            }

            _StaticInfo1 = new Statistics_info(sales, exporer, profit, count);

            return _StaticInfo1;


        }

        //info for month
        public Statistics_info ShowInfoSalesForMonthSalesman(string date, string NameUs)
        {
            int c = 0;
            string strMonth = "", strYear = "";
            for (int i = 0; i < date.Length; i++)
            {
                if (date[i] == '-')
                    c++;
                if (c == 0)
                    strMonth += date[i];
                else if (c == 1)
                    strYear += date[i];
            }

            DateTime mydateMonth;
            mydateMonth = funchelpMonth(strMonth);
            DateTime mydateYear;
            mydateYear = funchelp(strYear.Substring(1));

            float sales = 0, exporer = 0, profit = 0;
            int count = 0;

            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();

            for (int i = 0; i < _listSaleObject.Count; i++)
            {
                if (mydateMonth.Month == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Month && mydateYear.Year == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Year && _listSaleObject[i].getSalesman() == NameUs)
                {

                    count++;


                    sales += float.Parse(_listSaleObject[i].getPrice().ToString());

                    exporer += float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());

                    profit += float.Parse(_listSaleObject[i].getPrice().ToString()) - float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());


                }
            }

            _StaticInfo1 = new Statistics_info(sales, exporer, profit, count);

            return _StaticInfo1;


        }


        //func info month for lblmonth in dashboard Salesman
        public Statistics_info ShowInfoSalesForMonthLblSalesman( string NameUs )
        {

            float sales = 0, exporer = 0, profit = 0;
            int count = 0;

            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();

            for (int i = 0; i < _listSaleObject.Count; i++)
            {
                if (DateTime.Now.Month == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Month && DateTime.Now.Year == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Year && _listSaleObject[i].getSalesman() == NameUs)
                {

                    count++;


                    sales += float.Parse(_listSaleObject[i].getPrice().ToString());

                    exporer += float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());

                    profit += float.Parse(_listSaleObject[i].getPrice().ToString()) - float.Parse(_listSaleObject[i].getPriceForBusiness().ToString());


                }
            }

            _StaticInfo1 = new Statistics_info(sales, exporer, profit, count);

            return _StaticInfo1;


        }

        //info for sale in month for sale mangment
        public List<string> ShowInfoSalesForMonthForSaleMangment()
        {
            List<string> SaleOfMonth = new List<string>();
            int c = 0;
            string str="";
          

            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();

            for (int i = 0; i < _listSaleObject.Count; i++)
            {
                if (DateTime.Now.Month == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Month && DateTime.Now.Year == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Year)
                {

                    //str = _listSaleObject[i].getId() + "   " + _listSaleObject[i].getName() + "  " + _listSaleObject[i].getDate();
                    str = string.Format("{0,-3}{1,10}{2,10:#.00} {3,12}", _listSaleObject[i].getId(), _listSaleObject[i].getName(), _listSaleObject[i].getPrice(), _listSaleObject[i].getDate());
                    SaleOfMonth.Add(str);

                }
            }
            return SaleOfMonth;
        }

        //info for sale in month for sale salsmen
        public List<string> ShowInfoSalesForMonthForSalesmen( string nameUs )
        {
            List<string> SaleOfMonth = new List<string>();
            int c = 0;
            string str = "";


            _listSaleObject.Clear();
            _listSaleObject = _tmpSale.ShowListObject();

            for (int i = 0; i < _listSaleObject.Count; i++)
            {
                if (DateTime.Now.Month == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Month && DateTime.Now.Year == DateTime.Parse(_listSaleObject[i].getDate().ToString()).Year && _listSaleObject[i].getSalesman() == nameUs)
                {

                    str = string.Format("{0,-3}{1,10}{2,10:#.00} {3,12}", _listSaleObject[i].getId(), _listSaleObject[i].getName(), _listSaleObject[i].getPrice(), _listSaleObject[i].getDate());
                    SaleOfMonth.Add(str);

                }
            }
            return SaleOfMonth;
        }


        //count order month for order Suppliers
        public int ShowCountMonthForOrderSuppliers()
        {            
            int c = 0;
            _listOrderSuppliers.Clear();
            _listOrderSuppliers = tmpSuppliersOrder.ShowListObject();
            for (int i = 0; i < _listOrderSuppliers.Count; i++)
            {
                if (DateTime.Now.Month == DateTime.Parse(_listOrderSuppliers[i].getDate().ToString()).Month && DateTime.Now.Year == DateTime.Parse(_listOrderSuppliers[i].getDate().ToString()).Year)
                {
                    c++;
                }
            }
            return c;
        }


    }
}
