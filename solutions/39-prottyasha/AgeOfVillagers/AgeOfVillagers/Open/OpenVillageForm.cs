using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class OpenVillageForm : Form
    {
        SaveVillageForm svf;
        public OpenVillageForm()
        {
            InitializeComponent();
        }

        private void SavedVillageList_Click(object sender, EventArgs e)
        {
            SavedVillageList.Items.Clear();
            SavedVillageList.Items.Add(svf.savedVillList);
        }

        private void SavedVillageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string villageToOpen = SavedVillageList.SelectedIndex.ToString();
            Village vill = new Village();
            using (StreamReader r = new StreamReader(villageToOpen))
            {
                string json = r.ReadToEnd();
                vill = JsonConvert.DeserializeObject<Village>(json);
            }
            this.SetState(vill);
        }

        private void SetState(Village vill)
        {
            VillageWindow vw = new VillageWindow();
            vw.selected_nation = vill.nation;
            
            NationFactory nf = new NationFactory();
            INations nation = nf.GetNation(vill.village_name);
            //Graphics g = new Graphics();
            //Pen pen = Pen();
            
            foreach(Point p in vill.trees_drawn)
            {
                nation.drawtree(p, vw.g, vw.pen);
            }
            foreach (Point p in vill.houses_drawn)
            {
                nation.drawhouse(p, vw.g, vw.pen);
            }
            foreach (Point p in vill.rivers_drawn)
            {
                nation.drawwatersource(p, vw.g, vw.pen);
            }
        }
    }
}
