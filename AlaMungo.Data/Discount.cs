using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    public class Discount
    {
        public static int SalePrices(string quality, int price)
        {
            int result = 0;

            if (quality == "A")
                result = (int)(price * 0.9);

            else if (quality == "B")
                result = (int)(price * 0.8);

            else if (quality == "C")
                result = (int)(price * 0.7);

            else if (quality == "F")
                result = (int)(price * 0.5);

            return result;

        }
    }
}
