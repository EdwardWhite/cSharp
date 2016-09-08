using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using DataLayer;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            fileSelector.fileType = "csv";
            bool check = false;
          
            try
            {
                Console.WriteLine(  Environment.UserName );

                fileSelector.strfilename = Environment.ExpandEnvironmentVariables(@"C:\Users\" + Environment.UserName + @"\SkyDrive\user.csv");
                    if (!File.Exists(fileSelector.strfilename))
                    throw new FileNotFoundException();
            }
            catch (FileNotFoundException e)
            {
                if(check == false)
                {
                    Console.WriteLine("pleases enter file filter type");
                    Console.WriteLine("user");
                    Filter.filter = (Console.ReadLine());
                    fileSelector.fileType = Filter.Cleaned();
                    check = true;

                }
                Console.WriteLine("pleases Select User file");
            fileSelector.fileSelectors();
            }
  IEnumerable<user> users = ingest.userReads(fileSelector.filepath());

            try
            {

               String test =  Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "test.txt");


                fileSelector.strfilename = Environment.ExpandEnvironmentVariables(@"C:\Users\" + Environment.UserName + @"\SkyDrive\location.csv");
                if (!File.Exists(fileSelector.strfilename))
                    throw new FileNotFoundException();
            }
            catch (FileNotFoundException e)
            {
                if (check == false)
                {
                    Console.WriteLine("pleases enter file filter type");
                    Console.WriteLine("location");
                    Filter.filter = (Console.ReadLine());
                    fileSelector.fileType = Filter.Cleaned();
                    check = true;

                }
                Console.WriteLine("pleases Select location file");
                fileSelector.fileSelectors();
            }











            IEnumerable<Location> locations = ingest.locationReads(fileSelector.filepath());
          /*  var joined = from user in users
                         join location in locations
                         on user.locationID equals location.id
                         select new { users, locations }.;
            

    */
         


            var query = users.Filter(u => u.formalName.StartsWith("R"));

            foreach (var item in query)
            {
                Console.WriteLine(item.userName);
            }



                foreach (var item in query )
            {
            Console.WriteLine(item.userName +"    " + item.locationID);
            }
           
            Console.ReadLine();


            
        }
    }
}
