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
        public static void queryStartsWith (IEnumerable<user> users, String starts)
        {

            var query = users.Filter(u => u.formalName.StartsWith(starts));

            foreach (var item in query)
            {
                Console.WriteLine(item.userName);
            }
            Console.ReadLine();  
        }


    }
}
