using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class fileSelector
    {
        private String fileType ="*";
        private String strfilename ="";

        public fileSelector(String types)
        {
          fileType = types;
         }
     
        public String filepath()
        {
            return filelocation();
        }

        public void fileSelectors()
        {
            Fileselector();
        }





        private String filelocation()
        {
            return strfilename;
        }


        private void Fileselector()
        {
           
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*."+fileType;
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true         
                strfilename = choofdlog.InitialDirectory + choofdlog.FileName;
            }
        }


    }
}
