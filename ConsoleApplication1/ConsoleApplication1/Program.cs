using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Filter a = new Filter(Console.ReadLine());
            fileSelector file = new fileSelector(a.Cleaned());
            if (file.checkArray().Equals(true))
            {
                Console.WriteLine(file.filepath());
            }
            else
            {
                foreach (String c in file.filepath(file.checkArray()))
                {
                    Console.WriteLine(c);
                    //comment
                }
            }
            Console.ReadLine();
        }
    }
}
