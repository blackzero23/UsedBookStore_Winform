using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;

namespace AlaMungo.Data
{
    public class SellData : EntityData<Sell>
    {
        public List<Sell> Search(string sellerId, bool? bookChecked)
        {
            using(YesAlaMungoEntities context = new YesAlaMungoEntities())
            {
                //var query = from x in context.Sells
                //            join y in context.Customers on x.SellID equals y.CustomerID
                //var query = from x in context.Sells
                //    join y in context.UsedBooks on x.SellID equals y.UsedBookID
                //    join z in context.Customers on x.SellID equals z.CustomerID
                //    select new
                //    {
                //        Sells = x,
                //        Customer =z,
                //        LoginID = z.LoginID,
                //        Title = y.MetaDataBook.Title,
                //        Quality = y.Quality,
                //        Price =  y.MetaDataBook.Price
                //    };

                var query = from x in context.SellUsedBooks
                            select new
                            {
                                Sells = x.Sell,
                                Customer = x.Sell.Customer,
                                LoginID = x.Sell.Customer.LoginID,
                                Title = x.UsedBook.MetaDataBook.Title,
                                Quality = x.UsedBook.Quality,
                                Price = x.UsedBook.MetaDataBook.Price
                            };

                if (string.IsNullOrEmpty(sellerId) == false)
                    query = query.Where(x => x.Customer.LoginID.Equals(sellerId));

                if (bookChecked != null)
                    query = query.Where(x => x.Sells.Checked == bookChecked);

                var list = query.ToList();

                foreach (var item in list)
                {
                    item.Sells.Title = item.Title;
                    item.Sells.Quality = item.Quality;
                    item.Sells.Price = item.Price;
                    item.Sells.LoginID = item.LoginID;
                }

                return list.ConvertAll(x=>x.Sells);
            }
        }

        public UsedBook SearchBook(Sell sell)
        {
            using (YesAlaMungoEntities context = new YesAlaMungoEntities())
            {
                var query = from x in context.SellUsedBooks
                    where x.SellID.Equals(sell.SellID)
                    select new
                    {
                       UsedBook =  x.UsedBook,
                       Title = x.UsedBook.MetaDataBook.Title,
                       Writer = x.UsedBook.MetaDataBook.Writer,
                       Publisher = x.UsedBook.MetaDataBook.Publisher,
                       Price = x.UsedBook.MetaDataBook.Price,
                       ImagePath = x.UsedBook.MetaDataBook.Image
                    };

                var list = query.ToList();

                foreach (var item in list)
                {
                    item.UsedBook.Title = item.Title;
                    item.UsedBook.Writer = item.Writer;
                    item.UsedBook.Publisher = item.Publisher;
                    item.UsedBook.Price = item.Price;
                    item.UsedBook.ImagePath = item.ImagePath;
                }

                return list.ConvertAll(x => x.UsedBook).FirstOrDefault();
            }
        }
    }
}
