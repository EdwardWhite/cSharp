using System;

namespace ConsoleApplication1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Filter a = new Filter(Console.ReadLine());
            fileSelector file = new fileSelector(a.Cleaned());

            bool test = file.checkArray();


            foreach (String c in file.filepath(file.checkArray()))
            {
                Console.WriteLine(c);
            }

            switch (test)
            {
                case true:
                    Console.WriteLine(file.filepath());
                    break;
                case false:
                    foreach (String c in file.filepath(file.checkArray()))
                    {
                        Console.WriteLine(c);
                    }
                    break;
            }

         



            Console.ReadLine();
        }
    }
}
