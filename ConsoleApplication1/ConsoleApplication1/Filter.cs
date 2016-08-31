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
       
        private String filter;
        private String CleanedFilter;

        public Filter(String n)
        {
            filter = n;
        }

        public String Cleaned()
        {
            cleaning();
            return CleanedFilter;
        }

        private void cleaning()
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
