using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace applicationlayer
{
    class AppSettings
    {
        public static String[] Types = { "user", "Location" };


        public static void appStart()
        {
           fileSelector.fileType = "csv";
        fileSelector.switches = false;
          
        }

       

    }
}