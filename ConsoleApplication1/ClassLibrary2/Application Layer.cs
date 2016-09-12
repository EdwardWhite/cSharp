using applicationlayer;
using Businesslogic;
using ClassLibrary;
using DataLayer;
using System;
using System.Collections.Generic;

namespace applicationLayer
{

    class applicationlayer
    {
       

        [STAThread]

       
        public static void Main()
                    {

            Initial.Load(AppSettings.Types[0]);
            IEnumerable<user> users = ingest.userReads(fileSelector.filepath());
            Initial.Load(AppSettings.Types[1]); 
            IEnumerable<Location> locations = ingest.locationReads(fileSelector.filepath());

            IEnumerable<user> query = BSLogic.queryStartsWith(users, "R");

            foreach(user item in query)
            {
                Console.WriteLine(item.formalName);
            }

            Console.ReadLine();

        }



    }
}
