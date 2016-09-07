using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
  
    public class Filter
    {


        public static String filter { get; set; }

        public static String CleanedFilter { get; set; }
      

      
        public static String Cleaned()
        {
            cleaning();
            return CleanedFilter;
        }

        private  static void cleaning()
        {
            var sb = new StringBuilder();

            foreach (char c in filter)
            {
                if (char.IsLetterOrDigit(c))
                    sb.Append(c);
            }
            
            CleanedFilter = sb.ToString();
        }

       
    }



   
}
