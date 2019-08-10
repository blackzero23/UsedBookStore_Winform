using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    partial class Buy
    {
        public string Title { get; set; }
        public string BuyerLoginID { get; set; }
        public string Writer { get; set; }
        public string Pubilsher { get; set; }
        public string Quality { get; set; }
        public int Price { get; set; }
        public string ImagePath { get; set; }
    }
}
