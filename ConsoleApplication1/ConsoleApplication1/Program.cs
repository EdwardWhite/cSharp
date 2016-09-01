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

            test == true ? Console.WriteLine(file.filepath()) :;
                
                
                
                file.filepath(file.checkArray()).to

                
                
                
                .ForEach( i => Console.WriteLine(i));


            file.filepath(file.checkArray()).ToList().ForEach(n => Console.WriteLine(n));
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
