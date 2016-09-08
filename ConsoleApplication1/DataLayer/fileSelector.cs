using System;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public static class fileSelector
    {
  
        public static String fileType { get; set; }
        public static String strfilename { get; set; }


        public static String filepath()
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
