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
        public void saveVillage <Village> (string filePath, Village objectToWrite, bool append = false)
        {
            var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite,Formatting.Indented);
            System.IO.File.WriteAllText(filePath, contentsToWriteToFile);
        }
        public Village openVillage(string filePath,AgeOfVillagersForm ageOfVillagersForm)
        {
            Color color=Color.White;
            Village village = JsonConvert.DeserializeObject<Village>(File.ReadAllText(filePath));
            //MessageBox.Show(village.village);
            //AgeOfVillagersForm ageOfVillagersForm = new AgeOfVillagersForm();
            ageOfVillagersForm.lblNationName.Text = village.nation;
            ageOfVillagersForm.lblVillageName.Text = village.village;
            if (village.nation == "Arab Bedouin")
            {
                ageOfVillagersForm.radiobtnWaterSource.Enabled = false;
                color = Color.LightYellow;
                //ageOfVillagersForm.pnlDrawingSpace.BackColor = Color.LightYellow;
            }
            else if (village.nation == "Inuit Hunter")
            {
                ageOfVillagersForm.radiobtnTree.Enabled = false;
                ageOfVillagersForm.radiobtnWaterSource.Enabled = false;
                color = Color.White;
                //ageOfVillagersForm.pnlDrawingSpace.BackColor = Color.White;
            }
            else if (village.nation == "Egyptian King")
            {
                color = Color.Yellow;
                //ageOfVillagersForm.pnlDrawingSpace.BackColor = Color.Yellow;
            }
            else if (village.nation == "Bangladeshi Farmer")
            {
                color = Color.Green;
                //ageOfVillagersForm.pnlDrawingSpace.BackColor = Color.Green;
            }
            ageOfVillagersForm.pnlDrawingSpace.BackColor = color;

            /*ageOfVillagersForm.villageComponentFactory = NationFactory.getNation(village.nation);
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
            }*/
            draw(ageOfVillagersForm, village);
            //MessageBox.Show("Done all");
            //ageOfVillagersForm.Show();
            return village;
        }
        public void draw(AgeOfVillagersForm ageOfVillagersForm, Village village)
        {
            ageOfVillagersForm.villageComponentFactory = NationFactory.getNation(village.nation);
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
