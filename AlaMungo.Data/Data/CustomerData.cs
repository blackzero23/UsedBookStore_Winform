using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    public class CustomerData : EntityData<Customer>
    {

        public Customer Check(string id, string pw)
        {
            using (YesAlaMungoEntities context = new YesAlaMungoEntities())
            {
                var query = from x in context.Customers
                            where x.LoginID.Equals(id) && x.PassWord.Equals(pw)
                            select x;
                var list = query.ToList();


                return list.FirstOrDefault();                
            }
        }

        public List<Customer> CheckUser(string id, string pw)
        {
            using (YesAlaMungoEntities context = new YesAlaMungoEntities())
            {
                var query = from x in context.Customers
                            where x.LoginID.Equals(id) && x.PassWord.Equals(pw)
                            select x;

                return query.ToList();
            }
        }

        public bool CheckId(string id)
        {
            using (YesAlaMungoEntities context = new YesAlaMungoEntities())
            {
                var query = from x in context.Customers
                            where x.LoginID.Equals(id)
                            select x;

                return query.Any();
            }
        }
    }
}
