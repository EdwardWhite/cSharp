using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DataRecord
    {
        //Should have properties which correspond to the Column Names in the file
        //i.e. CommonName,FormalName,TelephoneCode,CountryCode
        public String CommonName { get; set; }
        public String FormalName { get; set; }
        public String TelephoneCode { get; set; }
        public String CountryCode { get; set; }
    }


    public class user
    {
        public String userName { get; set; }
        public String passWordUnhashed { get; set; }
        public String passWordHashed { get; set; }
        public String commonName { get; set; }
        public String formalName { get; set; }
        public String telephoneNumber { get; set; }
        public String locationID { get; set; }

    }

    public class Location
    {

        public String id { get; set; }

        public String doorNumber { get; set; }
        public String firstLine { get; set; }
        public String secondLine { get; set; }
        public String postCode { get; set; }

    }



}
