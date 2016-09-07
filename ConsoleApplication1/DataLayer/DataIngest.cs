using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Diagnostics;
using ClassLibrary1;

namespace DataLayer
{
  

   public static class ingest
    {

  public static IEnumerable<DataRecord> Reads(string v)
        {
            
            var reader = new CsvReader(File.OpenText(v));
            IEnumerable<DataRecord> records = reader.GetRecords<DataRecord>();

            records.ToList().ForEach(n => Console.WriteLine($"{n.CommonName, -52} :{n.TelephoneCode,3}"));
            return records;
    }
    }

      

}

