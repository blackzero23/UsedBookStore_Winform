using AlaMungo.Data;
using AlaMungo.Employee.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlaMungo.Employee.Forms
{
    public partial class UsedBookListForm : Form
    {
        private Data.Employee _employee;
        public UsedBookListForm()
        {
            InitializeComponent();
        }

        public UsedBookListForm(Data.Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            Icon = Resources.Book11;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UscSearch_SearchButtonCliked(object sender, Controls.UsedBookSearchControl.SearchButtonClikedEventArgs e)
        {
            List<UsedBook> usedBooks = DB.UsedBook.Search(e.Title, e.Writer, e.Quality);

            uscList.SetDataSource(usedBooks);
        }

        private void UscList_RowDoubleClicked(object sender, Controls.UsedBookListControl.RowDoubleClickedEventArgs e)
        {
            UsedBookInfoForm usedBook = new UsedBookInfoForm(e.UsedBook);
            usedBook.ShowDialog();
        }
    }
}
