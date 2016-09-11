using DataLayer;
using System;



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