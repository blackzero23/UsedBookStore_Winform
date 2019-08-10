using AlaMungo.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlaMungo.Customer.Controls
{
    public partial class InvoiceListControl : UserControl
    {
        public InvoiceListControl()
        {
            InitializeComponent();
        }

        public void SetDateSource(List<Buy> buys)
        {
            dgvList.DataSource = buys;
            lblCount.Text = $"총 {buys.Count} 건 입니다.";
        }

        private void DgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                if(e.Value != null)
                {
                    switch(e.Value)
                    {
                        case 0: e.Value = "배송 준비중";
                        break;
                        case 1: e.Value = "배송 중";
                            break;
                        case 2: e.Value = "배송 완료";
                          break;
                    }
                }
            }
        }
    }
}
