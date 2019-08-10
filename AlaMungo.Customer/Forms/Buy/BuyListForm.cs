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
    public partial class BuyListForm : Form
    {
        private Data.Customer _customer;

        public BuyListForm()
        {
            InitializeComponent();
            Icon = Resources.Purchase1;
        }

        public BuyListForm(Data.Customer customer)
        {
            InitializeComponent();
            Icon = Resources.Purchase1;
            _customer = customer;
        }

        private void BuyListForm_Load(object sender, EventArgs e)
        {
            //uscSearch.LoadQualitys();
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.BuySearchControl.SearchButtonClickedEventArgs e)
        {
            var usedBooks = DB.UsedBook.Search(e.Title, e.Writer, e.Quality);
            uscList.SetDataSource(usedBooks);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UscList_RowDoubleClicked(object sender, Controls.BuyListControl.RowDoubleClickedEventArgs e)
        {
            UsedBook usedBook = e.UsedBook;
            if (usedBook == null)  // 형 변환 실패...
                return;

            UsedBookForm form = new UsedBookForm(_customer,usedBook);
            form.ShowDialog();
        }

       
    }
}
