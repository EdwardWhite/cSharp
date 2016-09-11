using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using applicationlayer;
using Businesslogic;
using ClassLibrary;
using DataLayer;


namespace ApplicationLayer
{

    public partial class Form1 : Form
    {
        IEnumerable<user> query;
        public Form1()
        {
            Initial.Load(AppSettings.Types[0]);
            IEnumerable<user> users = ingest.userReads(fileSelector.filepath());
            Initial.Load(AppSettings.Types[1]);
            IEnumerable<Location> locations = ingest.locationReads(fileSelector.filepath());
            IEnumerable<user> query = BSLogic.queryStartsWith(users, "R");
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
