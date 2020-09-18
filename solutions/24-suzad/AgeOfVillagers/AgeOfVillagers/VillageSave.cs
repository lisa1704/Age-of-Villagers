using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class VillageSave
    {

        public void saveVillage <Village> ( Village objectToWrite, bool append = false)
        {
            var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite, Formatting.Indented);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save aov file";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "aov";
            saveFileDialog.OverwritePrompt = true;
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                
                System.IO.File.WriteAllText(path, contentsToWriteToFile);
            }
        }
        public Village openVillage(AgeOfVillagersForm ageOfVillagersForm, string filePath, string nation)
        {
            //Color color=Color.White;
            Village village = JsonConvert.DeserializeObject<Village>(File.ReadAllText(filePath));
            /*ageOfVillagersForm.lblNationName.Text = village.nation;
            ageOfVillagersForm.lblVillageName.Text = village.village;
            if (village.nation == "Arab Bedouin")
            {
                ageOfVillagersForm.radiobtnWaterSource.Enabled = false;
                color = Color.LightYellow;
            }
            else if (village.nation == "Inuit Hunter")
            {
                ageOfVillagersForm.radiobtnTree.Enabled = false;
                ageOfVillagersForm.radiobtnWaterSource.Enabled = false;
                color = Color.White;
            }
            else if (village.nation == "Egyptian King")
            {
                color = Color.Yellow;
            }
            else if (village.nation == "Bangladeshi Farmer")
            {
                color = Color.Green;
            }
            ageOfVillagersForm.pnlDrawingSpace.BackColor = color;
            //draw(ageOfVillagersForm, village);
            //return village;*/
            ageOfVillagersForm.setNationProperty(nation);
            ageOfVillagersForm.setVillageName(village.village);
            return village;
        }
        public void draw(AgeOfVillagersForm ageOfVillagersForm, Village village, string nation)
        {
            ageOfVillagersForm.villageComponentFactory = NationComponentFactory.getNation(nation);
            foreach (Point point in village.treePoints)
            {
                VillageComponent villageComponent = ageOfVillagersForm.villageComponentFactory.getComponent("Tree", point);
                villageComponent.drawComponent(point, ageOfVillagersForm.graphics, ageOfVillagersForm.pen);
            }
            foreach (Point point in village.housePoints)
            {
                VillageComponent villageComponent = ageOfVillagersForm.villageComponentFactory.getComponent("House", point);
                villageComponent.drawComponent(point, ageOfVillagersForm.graphics, ageOfVillagersForm.pen);
            }
            foreach (Point point in village.riverPoints)
            {
                VillageComponent villageComponent = ageOfVillagersForm.villageComponentFactory.getComponent("Water source", point);
                villageComponent.drawComponent(point, ageOfVillagersForm.graphics, ageOfVillagersForm.pen);
            }
        }
    }
}
