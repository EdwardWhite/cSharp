using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using DataLayer;

namespace ConsoleApplication1
{
    class Program
    {
        [STAThread]
        public static void Main()
        {


            Console.WriteLine("pleases enter file filter type");
            Filter.filter = (Console.ReadLine());
            fileSelector.fileType = Filter.Cleaned();
            fileSelector.fileSelectors();

            ingest.Reads(fileSelector.filepath());

            Console.ReadLine();


            
        }
    }
}
