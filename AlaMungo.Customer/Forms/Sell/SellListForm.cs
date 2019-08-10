using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlaMungo.Data;

namespace AlaMungo.Customer.Forms
{
    public partial class SellListForm : Form
    {

        private Data.Customer _customer;

        public SellListForm()
        {
            InitializeComponent();
        }

        public SellListForm(Data.Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        private void UscSearch_SearchButtonClicked(object sender, Controls.SellSearchControl.SearchButtonClickedEventArgs e)
        {
            List<MetaDataBook> metaDataBooks = DB.MetaDataBook.Search(e.Title, e.Writer, e.Publisher);

            uscList.SetDataSource(metaDataBooks);
        }

        private void UscList_RowDoubleClicked(object sender, Controls.SellListControl.RowDoubleClickedEventArgs e)
        {
            SellBookForm infoFrom = new SellBookForm(_customer,e.MetaDataBook);
            infoFrom.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
