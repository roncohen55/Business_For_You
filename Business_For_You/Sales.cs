using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Business_For_You
{
    public partial class Sales : Form
    {
        private string _NameUser;

        private Sales_class tmp = new Sales_class();

        private Sales_class _SaleInfo11;

        private List<Sales_class> _listObjectSale = new List<Sales_class>();

        public Sales(string nameUs)
        {
            InitializeComponent();
            _listObjectSale = tmp.ShowListObject();
            _NameUser = nameUs;
            ShowSales(nameUs);
        }

        private void ShowSales(string nameUser)
        {
            try
            {
                listBox1.Items.Clear();
                List<string> tmp1 = new List<string>();
                tmp1 = tmp.ShowListForSalesman(nameUser);
                for (int i = 0; i < tmp1.Count; i++)
                    listBox1.Items.Add(tmp1[i]);

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowinfoFromdata()
        {
            try
            {
                
                string str = "";
             
              _SaleInfo11 = tmp.ShowinfoFromdata(listBox1.Text);
               

                str ="פרטי הזמנה"+"\n"+"מספר הזמנה" +" "+_SaleInfo11.getId().ToString() + "\n"+"מוצרים"+" " + _SaleInfo11.getInfo() + "\n" +"מוצרים וכמות"+" "+_SaleInfo11.getQuantityInfo()+"\n" +"מחיר"+" "+ _SaleInfo11.getPrice().ToString() + "\n" +"שם הקונה"+" "+ _SaleInfo11.getName() + "\n"+"הערות"+" " + _SaleInfo11.getNote() + "\n"+"מספר פאלפון"+" " + _SaleInfo11.getPhone() + "\n"+"כתובת"+" " + _SaleInfo11.getAddress() + "\n" +"אימייל"+" "+_SaleInfo11.getEmail()+"\n" +_SaleInfo11.getDate();

                lblInformation.Text = str;
               

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     

        //delete one sale
        private void DeleteSale()
        {

            try
            {

                tmp.Delete(listBox1.Text);
                MessageBox.Show("Delete Sucsses");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btninformation_Click(object sender, EventArgs e)
        {
            ShowinfoFromdata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSale();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAllSale_Click(object sender, EventArgs e)
        {
            ShowSales(_NameUser);
        }

        private void btnSaleOfMonth_Click(object sender, EventArgs e)
        {
            try
            {
                Statistics_info s1 = new Statistics_info();
                listBox1.Items.Clear();

                List<string> tmp1 = new List<string>();
                tmp1 = s1.ShowInfoSalesForMonthForSalesmen(_NameUser);
                for (int i = 0; i < tmp1.Count; i++)
                    listBox1.Items.Add(tmp1[i]);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                for (int i = 0; i < _listObjectSale.Count; i++)
                {
                    if (int.Parse(txtSearch.Text) == _listObjectSale[i].getId() && _listObjectSale[i].getSalesman().Trim() == _NameUser.Trim())
                    {

                        str = string.Format("{0,-3}{1,10}{2,10:#.00} {3,12}", _listObjectSale[i].getId(), _listObjectSale[i].getName(), _listObjectSale[i].getPrice(), _listObjectSale[i].getDate());
                    }

                }
                if (str != "")
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(str);
                }

                else
                    MessageBox.Show("לא נמצא עיסקה", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreatePdf_Click(object sender, EventArgs e)
        {
            _SaleInfo11 = tmp.ShowinfoFromdata(listBox1.Text);
            
            Document Doc = new Document(PageSize.A4);
            //
            string makat = "";
            string str = _SaleInfo11.getInfo();
            int c = 0;
            for(int i=0; i < str.Length; i++)
            {
                if(str[i]>='0' && str[i] <= '9' && c!=0 && i != 0)
                {
                    c = 0;
                    makat += "\n";
                  
                }
                if (str[i] == ' ')
                    c++;
                if (c == 0)
                    makat += str[i];
            }
            string[] tmpInfo = _SaleInfo11.getQuantityInfo().Split('\n');
            string[] arr = makat.Split('\n');
            string Info = "";
            for (int i = 0; i < arr.Length; i++)
            {

                Info += arr[i] + ' ' + tmpInfo[i]+ "\n";
            }


            //Create our file stream
            using (FileStream fs = new FileStream($@".\order\{_SaleInfo11.getId()}.pdf", FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                //Bind PDF writer to document and stream
                PdfWriter writer = PdfWriter.GetInstance(Doc, fs);

                //Open document for writing
                Doc.Open();

                //Add a page
                Doc.NewPage();

                //Full path to the Arial file
                string ARIALUNI_TFF = Path.Combine(@"Alef-Bold.ttf");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object
                iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12);

                //Use a table so that we can set the text direction
                PdfPTable TId = new PdfPTable(1);
                PdfPTable TDate = new PdfPTable(1);
                //PdfPTable TName = new PdfPTable(1);
               // PdfPTable TPhone = new PdfPTable(1);
                PdfPTable TAdress = new PdfPTable(1);
                PdfPTable TInfo = new PdfPTable(1);
                PdfPTable TPrice = new PdfPTable(1);
                PdfPTable TSalsmen = new PdfPTable(1);
                PdfPTable TEmail = new PdfPTable(1);
                PdfPTable Tquantity = new PdfPTable(1);
                PdfPTable TNote = new PdfPTable(1);

                //Hide the table border
                TId.DefaultCell.BorderWidth = 0;
                TDate.DefaultCell.BorderWidth = 0;
               // TName.DefaultCell.BorderWidth = 0;
                TAdress.DefaultCell.BorderWidth = 0;
               // TPhone.DefaultCell.BorderWidth = 0;
                TEmail.DefaultCell.BorderWidth = 0;
                TInfo.DefaultCell.BorderWidth = 0;
                TSalsmen.DefaultCell.BorderWidth = 0;
                TPrice.DefaultCell.BorderWidth = 0;
                //Tquantity.DefaultCell.BorderWidth = 0;
                TNote.DefaultCell.BorderWidth = 0;
                //Set RTL mode
                TId.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                //TName.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                TAdress.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
              //  TPhone.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                TEmail.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                TInfo.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                TSalsmen.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                TPrice.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                Tquantity.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                TNote.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
                //Add our text
                TId.AddCell(new Phrase($"מספר הזמנה {_SaleInfo11.getId()}                                              שם לקוח {_SaleInfo11.getName()}", f));
                TDate.AddCell(new Phrase($"\n\n{_SaleInfo11.getDate()}", f));
               //TName.AddCell(new Phrase($"\nשם לקוח {_SaleInfo11.getName()}", f));
                TAdress.AddCell(new Phrase($"\nכתובת {_SaleInfo11.getAddress()}                                              מספר פאלפון {_SaleInfo11.getPhone()}", f));
              //  TPhone.AddCell(new Phrase($"\nמספר פאלפון {_SaleInfo11.getPhone()}", f));
                TEmail.AddCell(new Phrase($"\nמייל {_SaleInfo11.getEmail()}\n\n", f));
                //TInfo.AddCell(new Phrase($"\nפרטים:\n\n {_SaleInfo11.getInfo()}", f));
                Tquantity.AddCell(new Phrase($"\nפרטים וכמות:\n\n{Info}     ", f));
                TNote.AddCell(new Phrase($"\nהערות {_SaleInfo11.getNote()}", f));
                TSalsmen.AddCell(new Phrase($"\nשם המוכר {_SaleInfo11.getSalesman()}", f));
                TPrice.AddCell(new Phrase($"\nמחיר {_SaleInfo11.getPrice()} ₪", f));
                //Add table to document
                Doc.Add(TDate);
                Doc.Add(TId);
               //Doc.Add(TName);
                Doc.Add(TAdress);
                //Doc.Add(TPhone);
                Doc.Add(TEmail);
               // Doc.Add(TInfo);
                Doc.Add(Tquantity);
                Doc.Add(TNote);
                Doc.Add(TSalsmen);
                Doc.Add(TPrice);
                //Close the PDF
                Doc.Close();

            }

            MessageBox.Show("קובץ נוצר", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
