using System.Collections.Generic;
using CsvHelper;
using System.IO;
using ClassLibrary;

namespace DataLayer
{


    public static class ingest
    {

        public static IEnumerable<user> userReads(string filePath)
        {
            
            var reader = new CsvReader(File.OpenText(filePath));

            return  reader.GetRecords<user>(); ;
      }

        public static IEnumerable<Location> locationReads(string filePath)
        {

            var reader = new CsvReader(File.OpenText(filePath));

            return reader.GetRecords<Location>(); ;
        }


    }



      

}

