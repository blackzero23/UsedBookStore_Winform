using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    public class EmployeeData : EntityData<Employee>
    {
        public Employee Check(string id, string pw)
        {
            using (YesAlaMungoEntities context = new YesAlaMungoEntities())
            {
                var query = from x in context.Employees
                    where x.LoginID.Equals(id) && x.PassWord.Equals(pw)
                    select x;

                var list = query.ToList();

                if (list.Count() != 0)
                    return list[0];
                else
                    return null;
            }
        }
    }
}
