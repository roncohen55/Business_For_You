using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Business_For_You
{
    public partial class OrderFromSuppliers : Form
    {
        private OrdersSuppliers_class tmpSuppliersOrder = new OrdersSuppliers_class();

        private OrdersSuppliers_class _suppliersInfo;

        private List<OrdersSuppliers_class> _listObjectOrderSuppliers = new List<OrdersSuppliers_class>();

        public OrderFromSuppliers()
        {
            InitializeComponent();
            _listObjectOrderSuppliers = tmpSuppliersOrder.ShowListObject();
            ShowOrderSuppliers();
        }

        private void ShowOrderSuppliers()
        {
            try
            {
                listBox1.Items.Clear();
                List<string> tmp1 = new List<string>();
                tmp1 = tmpSuppliersOrder.ShowList();
                for (int i = 0; i < tmp1.Count; i++)
                    listBox1.Items.Add(tmp1[i]);

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //show all data from one order Suppliers
        private void ShowinfoFromdata()
        {
            try
            {
                _suppliersInfo = tmpSuppliersOrder.ShowinfoFromdata(listBox1.Text);

                string str = "";

                str = "פרטי הזמנה מספק" + "\n" + "מספר ספק" + " " + _suppliersInfo.getId().ToString() + "\n" + "שם ספק" + " " + _suppliersInfo.getName() + "\n" + "שם עובד" + " " + _suppliersInfo.getNameSalesman() + "\n" + "פירוט על ההזמנה" + " " + _suppliersInfo.getDetails().ToString() + "\n" + "מחיר" + " " + _suppliersInfo.getPrice() + "\n" + "תאריך" + " " + _suppliersInfo.getDate();
                lblInfo.Text = str;

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //delete one order Suppliers
        private void DeleteSuppliers()
        {
            try
            {
                tmpSuppliersOrder.Delete(listBox1.Text);
                MessageBox.Show("Delete Sucsses");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OrderFromSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ShowinfoFromdata();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSuppliers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAllOrderSuppliers_Click(object sender, EventArgs e)
        {
            ShowOrderSuppliers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                for (int i = 0; i < _listObjectOrderSuppliers.Count; i++)
                {
                    if (int.Parse(txtSearch.Text) == _listObjectOrderSuppliers[i].getId())
                    {
                        str = _listObjectOrderSuppliers[i].getId() + "   " + _listObjectOrderSuppliers[i].getName() + "   " + _listObjectOrderSuppliers[i].getDate();
                        //str = string.Format("{0,-3}{1,10}{2,10:#.00} {3,12}", _listObjectSale[i].getId(), _listObjectSale[i].getName(), _listObjectSale[i].getPrice(), _listObjectSale[i].getDate());
                    }

                }
                if (str != "")
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add(str);
                }

                else
                    MessageBox.Show("לא נמצא הזמנה", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Business For You", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreatePdf_Click(object sender, EventArgs e)
        {
            _suppliersInfo = tmpSuppliersOrder.ShowinfoFromdata(listBox1.Text);

            Document Doc = new Document(PageSize.A4);
            Suppliers_Class suppliersEmailAndPhone = tmpSuppliersOrder.GiveMeSuppliersEmailAndPhone(_suppliersInfo.getName());


            //Create our file stream
            using (FileStream fs = new FileStream($@".\orderSuppliers\{_suppliersInfo.getId()}.pdf", FileMode.Create, FileAccess.Write, FileShare.Read))
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
                TId.AddCell(new Phrase($"מספר הזמנה {_suppliersInfo.getId()}                                              שם ספק {_suppliersInfo.getName()}", f));
                TDate.AddCell(new Phrase($"\n\n{_suppliersInfo.getDate()}", f));
                //TName.AddCell(new Phrase($"\nשם לקוח {_SaleInfo11.getName()}", f));
                TEmail.AddCell(new Phrase($"\nמייל {suppliersEmailAndPhone.getEmail()}                                    מספר פאלפון {suppliersEmailAndPhone.getPhone()}\n", f));
                //  TPhone.AddCell(new Phrase($"\nמספר פאלפון {_SaleInfo11.getPhone()}", f));
                //TEmail.AddCell(new Phrase($"\nמייל {_suppliersInfo.getEmail()}\n\n", f));
                //TInfo.AddCell(new Phrase($"\nפרטים:\n\n {_SaleInfo11.getInfo()}", f));
                Tquantity.AddCell(new Phrase($"\nפרטים וכמות:\n\n{_suppliersInfo.getDetails()}     ", f));
                //TNote.AddCell(new Phrase($"\nהערות {phone}", f));
                TSalsmen.AddCell(new Phrase($"\nשם המוכר {_suppliersInfo.getNameSalesman()}", f));
                TPrice.AddCell(new Phrase($"\nמחיר {_suppliersInfo.getPrice()} ₪", f));
                //Add table to document
                Doc.Add(TDate);
                Doc.Add(TId);
                //Doc.Add(TName);
               // Doc.Add(TAdress);
                //Doc.Add(TPhone);
                Doc.Add(TEmail);
                // Doc.Add(TInfo);
                Doc.Add(Tquantity);
               // Doc.Add(TNote);
                Doc.Add(TSalsmen);
                Doc.Add(TPrice);
                //Close the PDF
                Doc.Close();

            }

            MessageBox.Show("קובץ נוצר", " Business For You", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
