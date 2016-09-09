using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Initial
    {
        public static void Load(string Type)
        {

            try
            {
                fileSelector.strfilename = Environment.ExpandEnvironmentVariables(@"C:\Users\" + Environment.UserName + @"\SkyDrive\" + Type + @".csv");
                if (!File.Exists(fileSelector.strfilename))
                    throw new FileNotFoundException();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.GetType());
                if (fileSelector.switches == false)
                {
                    Console.WriteLine("pleases enter file filter type");
                    Filter.filter = (Console.ReadLine());
                    fileSelector.fileType = Filter.Cleaned();
                    fileSelector.switches = true;

                }
                Console.WriteLine("pleases Select " + Type + " file");
                fileSelector.fileSelectors();
            }
        }
    }
}
