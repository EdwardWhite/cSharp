using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using DataLayer;
using System.IO;


namespace Businesslogic
{
   public class BSLogic
    {
        public static IEnumerable<user> queryStartsWith (IEnumerable<user> users, String starts)
        {
            return  users.Filter(u => u.formalName.StartsWith(starts));
        }
        public static IEnumerable<user> queryEndsWith(IEnumerable<user> users, String starts)
        {
            return users.Filter(u => u.formalName.EndsWith(starts));
        }

        public static IEnumerable<user> locationFilter(IEnumerable<user> users, String starts)
        {
            return users.Filter(u => u.locationID.Equals(starts));
        }

    }
}
