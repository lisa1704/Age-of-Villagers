using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
//using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AgeOfVillagers
{
    public partial class SaveVillageForm : Form
    {
        Village vill;
        string village_name = "untitled";
        public List<string> savedVillList;
        public SaveVillageForm()
        {
            InitializeComponent();
        }

        private void save_villName_Click(object sender, EventArgs e)
        {
            if(textbox_VillageName.Text != "")
            {
                village_name = textbox_VillageName.Text;
            }
            vill.village_name = village_name;
            this.Save_Village();
        }

        public void Save_Village()
        {
            string path = vill.village_name + ".aov";
            using (StreamWriter aovfile = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(aovfile, vill);
            }

            savedVillList.Add(path);
        }
    }
}
