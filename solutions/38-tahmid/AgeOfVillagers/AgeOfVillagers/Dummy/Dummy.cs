using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Windows.Forms;


namespace AgeOfVillagers
{
    class Dummy
    {
        Panel p;
        internal void setName(System.Windows.Forms.Label village_name,Panel drawing)
        {
            
            village_name.Text = "woo";
            drawing = p;

        }

        internal void setObj(System.Windows.Forms.Label village_name,Panel drawing,Graphics g)
        {
            // Creating BlogSites object  
            BlogSites bsObj = new BlogSites()
            {
                Name = "C-sharpcorner",
                Description = "Share Knowledge"
      
            };

            // Convert BlogSites object to JOSN string format  
            string jsonData = JsonConvert.SerializeObject(bsObj);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "save village|*.aov";
            saveFileDialog1.Title = "Save village";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                var dataString = JsonConvert.SerializeObject(bsObj, Formatting.Indented);
                System.IO.File.WriteAllText(saveFileDialog1.FileName, dataString);
            }

            village_name.Text = jsonData;
            string json = jsonData;
            BlogSites bsObjj = JsonConvert.DeserializeObject<BlogSites>(json);
            //village_name.Text = bsObjj.Name;
           


        }

        internal void setPanel(Panel drawing_panel)
        {
            drawing_panel.Invalidate();
        }

        internal void openVillage(System.Windows.Forms.Label village_name)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "age of villagers file|*.aov";
            openFileDialog.Title = "open village";
            openFileDialog.ShowDialog();
            //exception needed
            var dataString = System.IO.File.ReadAllText(openFileDialog.FileName);
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };

            string json = dataString;

            BlogSites bsObjj = JsonConvert.DeserializeObject<BlogSites>(json,settings);
            village_name.Text = bsObjj.Name;
            //IState state = JsonConvert.DeserializeObject<IState>(dataString, settings);
        }

    }
}
