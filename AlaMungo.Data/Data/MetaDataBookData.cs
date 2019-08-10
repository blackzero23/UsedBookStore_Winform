using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    public class MetaDataBookData : EntityData<MetaDataBook>
    {
        public List<MetaDataBook> Search(string eTitle, string eWriter, string ePublisher)
        {
            using (YesAlaMungoEntities context = new YesAlaMungoEntities())
            {
                var query = from x in context.MetaDataBooks
                    select x;

                if (string.IsNullOrEmpty(eTitle) == false)
                    query = query.Where(x => x.Title.Contains(eTitle));
                if (string.IsNullOrEmpty(eWriter) == false)
                    query = query.Where(x => x.Writer.Contains(eWriter));
                if (string.IsNullOrEmpty(ePublisher) == false)
                    query = query.Where(x => x.Publisher.Contains(ePublisher));

                List<MetaDataBook> books = query.ToList();

                return books;
            }
        }
    }
}
