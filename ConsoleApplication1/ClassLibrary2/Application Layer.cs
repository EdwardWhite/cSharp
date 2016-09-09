using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DataLayer;
using Businesslogic;
using ClassLibrary;
using applicationlayer;
using System.Collections;

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

            BSLogic.queryStartsWith(users, "A");

        }


    }
}
