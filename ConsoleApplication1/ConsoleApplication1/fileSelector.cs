using System;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    class fileSelector
    {
        //file extensions
        //file type is started as * incase types is null so it will display all file types
        private String fileType ="*";
        private String strfilename ="";
            
       
        private bool test;


       private string[] arrAllFiles;
        public fileSelector(String types)
        {
            //takes sanitised input for filtered browsing 
            fileType = types;
            //running from constructor for encapsulation
            Fileselector();
            test = Array.Exists(arrAllFiles, element => element == null);
         }
     
        public String filepath()
        {
            return strfilename; 
        }

        public Array filepath(bool a)
        {
            return arrAllFiles;
        }

        public bool checkArray()
        {
            return test;
        }

     
        private void Fileselector()
        {
           
            OpenFileDialog log = new OpenFileDialog();
            //using file type to limit files shown 
            log.Filter = "All Files (*.*)|*."+fileType;
            log.FilterIndex = 1;
            log.Multiselect = true;

            if (log.ShowDialog() == DialogResult.OK)
            {
                string sFileName = log.FileName;
               arrAllFiles = log.FileNames; //used when Multiselect = true         
                strfilename = log.InitialDirectory + log.FileName;
            }
        }


    }
}
