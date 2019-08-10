using AlaMungo.Customer.Properties;
using AlaMungo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlaMungo.Customer.Forms
{
    public partial class OrderSheet : Form
    {
        private Data.Customer _customer;
        private UsedBook _usedBook;
        private Buy _buy = new Buy();
        public OrderSheet(UsedBook usedBook)
        {
            InitializeComponent(); _usedBook = usedBook;
            Icon = Resources.Purchase1;
        }

        public OrderSheet(Data.Customer customer,UsedBook usedBook)
        {
            InitializeComponent();

            _customer = customer;
            _usedBook = usedBook;
            Icon = Resources.Purchase1;
        }


        

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderSheet_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _usedBook.Title;
            lblPrice.Text = _usedBook.Price.ToString("C") + "\\";
            lblTotalPrice.Text = _usedBook.Price.ToString("C") + "\\";
        }

        private void ReadFromEntity()
        {
            lblTitle.Text = _usedBook.Title;
            lblPrice.Text = _usedBook.Price.ToString("C") + "\\";
            lblTotalPrice.Text = _usedBook.Price.ToString("C") + "\\";
        }

        private void WriterToEntity()
        {
            _buy.Address = txbAddress.Text;
            _buy.SubAddress = txbSubAddress.Text;
            _buy.OrderDate = DateTime.Now;
            _buy.InvoiceState = 0;
            _buy.BuyID = DB.Buy.GetCount()+1;
            _buy.BuyerID = _customer.CustomerID;

            
            _usedBook.IsSell = true;
            
        }

        

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            WriterToEntity();
            //if(_buy.BuyID == 0)
            
            //_buy.UsedBooks.Add(_usedBook);
            DB.Buy.Insert(_buy);
                      
            DB.UsedBook.Update(_usedBook);

            BuyUsedBook buyUsedBook = new BuyUsedBook();
            buyUsedBook.BuyID = _buy.BuyID;
            buyUsedBook.UsedBookID = _usedBook.UsedBookID;
            DB.BuyUsedBook.Insert(buyUsedBook);

            Close();
        }
    }
}
