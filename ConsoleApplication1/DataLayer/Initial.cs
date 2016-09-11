using System;
using System.IO;
using System.Windows.Forms;

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
                TypeCast();
             catchFilenotFound(Type);
            }
        }

        private static void TypeCast()
        {

            if (fileSelector.switches == false)
            {
                MessageBox.Show("Please Type in File Type", "Error File Filter", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Filter.filter = (Console.ReadLine());
                fileSelector.fileType = Filter.Cleaned();
                fileSelector.switches = true;

            }
        }

        public static void catchFilenotFound(string Type)
        {
            try
            {

                Console.WriteLine("Pleases Select " + Type + " file");
                fileSelector.fileSelectors();
            }
            catch (FileNotFoundException x)
            {
                catchFilenotFound(Type);
            }

        }
    }
}
