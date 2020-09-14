using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class VillageSave
    {
        Village village = new Village();
        /*AgeOfVillagersForm ageOfVillagersForm = new AgeOfVillagersForm();
        public string nation;
        public string village;
        public Panel drawingSpace;
        public void setFields()
        {
            nation = ageOfVillagersForm.lblNationName.Text;
            village = ageOfVillagersForm.lblVillageName.Text;
            drawingSpace = ageOfVillagersForm.pnlDrawingSpace;
        }*/
        public static void saveVillage <Village> (string filePath, Village objectToWrite, bool append = false)
        {
            //village.setFields();
            TextWriter writer = null;
            try
            {
                var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite,Formatting.Indented);
                System.IO.File.WriteAllText(filePath, contentsToWriteToFile);
                //writer = new StreamWriter(filePath, append);
                //writer.Write(contentsToWriteToFile);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}
