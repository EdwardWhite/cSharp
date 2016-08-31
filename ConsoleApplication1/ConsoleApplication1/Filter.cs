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

        //constructor 
        public Filter(String n)
        {
            filter = n;
            cleaning();
            //runs cleaning method for encasulation 
            // runs from constructor as it is the only function of class
        }

        // only public method for class
        public String Cleaned()
        {
            return CleanedFilter;
        }

        private void cleaning()
        {
            //string builder for easy appending 
            var sb = new StringBuilder();

            // char for sanitising input string for all symbols 
            foreach (char c in filter)
            {
                if (char.IsLetterOrDigit(c))
                    sb.Append(c);
            }
            CleanedFilter = sb.ToString();
        }

    }



   
}
