using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    public class UsedBookData :EntityData<UsedBook>
    {
        public List<UsedBook> Search(string title, string writer, string quality)
        {
            using (YesAlaMungoEntities context = DbContextFactory.Create())
            {
                var query = from x in context.UsedBooks
                            where x.IsSell == false
                            select new
                            {
                                UsedBook = x,
                                BookTitle = x.MetaDataBook.Title,
                                BookWriter = x.MetaDataBook.Writer,
                                BookPrice = x.MetaDataBook.Price,
                                ImagePath = x.MetaDataBook.Image,
                                BookPublisher = x.MetaDataBook.Publisher
                            };

                if (string.IsNullOrEmpty(title) == false)
                    query = query.Where(x => x.UsedBook.MetaDataBook.Title.Contains(title));

                if (string.IsNullOrEmpty(writer) == false)
                    query = query.Where(x => x.UsedBook.MetaDataBook.Writer.Contains(writer));

                if (string.IsNullOrEmpty(quality) == false)
                    query = query.Where(x => x.UsedBook.Quality.Contains(quality));

                

                var list = query.ToList();

                foreach (var item in list)
                {
                    item.UsedBook.Title = item.BookTitle;
                    item.UsedBook.Writer = item.BookWriter;
                    item.UsedBook.ImagePath = item.ImagePath;
                    item.UsedBook.Publisher = item.BookPublisher;

                    if (item.UsedBook.Quality == "A")
                        item.UsedBook.Price = (int)(item.BookPrice * 0.9);
                    else if (item.UsedBook.Quality == "B")
                        item.UsedBook.Price = (int)(item.BookPrice * 0.8);
                    else if (item.UsedBook.Quality == "C")
                        item.UsedBook.Price = (int)(item.BookPrice * 0.7);
                    else if (item.UsedBook.Quality == "F")
                        item.UsedBook.Price = (int)(item.BookPrice * 0.5);
                }

                return list.ConvertAll(x => x.UsedBook);
            }
        }
    }
}
