using System;
using System.Windows.Forms;

namespace DataLayer
{
    public static class fileSelector
    {
        public static bool switches { get; set; }
        public static string fileType { get; set; }
        public static string strfilename { get; set; }


        public static string filepath()
        {
            return filelocation();
        }

        public static void fileSelectors()
        {
            Fileselector();
        }

        private static String filelocation()
        {
            return strfilename;
        }


        private static void Fileselector()
        {
           
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*."+fileType;
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true         
                strfilename = choofdlog.InitialDirectory + choofdlog.FileName;
            }
        }


    }
}
