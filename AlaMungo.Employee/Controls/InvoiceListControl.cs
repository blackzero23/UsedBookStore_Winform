using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlaMungo.Data;

namespace AlaMungo.Employee.Controls
{
    public partial class InvoiceListControl : UserControl
    {
        public InvoiceListControl()
        {
            InitializeComponent();
        }


        public void SetDataSource(List<Buy> list)
        {
            bdsBuy.DataSource = list;
            lblCount.Text = $"{list.Count:N0} 건";
        }

        private void DgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (e.Value != null)
                {
                    switch (e.Value)
                    {
                        case 0:
                            e.Value = "배송 준비중";
                            break;
                        case 1:
                            e.Value = "배송 중";
                            break;
                        case 2:
                            e.Value = "배송 완료";
                            break;
                    }
                }
            }
        }
    }
}
