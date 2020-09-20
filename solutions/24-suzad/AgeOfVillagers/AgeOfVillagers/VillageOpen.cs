using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace AgeOfVillagers
{
    public class VillageOpen
    {
        public Village openVillage(AgeOfVillagersForm ageOfVillagersForm, string filePath, string nation)
        {
            Village village = JsonConvert.DeserializeObject<Village>(File.ReadAllText(filePath));
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
                ageOfVillagersForm.treePoints.Add(point);
            }
            foreach (Point point in village.housePoints)
            {
                VillageComponent villageComponent = ageOfVillagersForm.villageComponentFactory.getComponent("House", point);
                villageComponent.drawComponent(point, ageOfVillagersForm.graphics, ageOfVillagersForm.pen);
                ageOfVillagersForm.housePoints.Add(point);
            }
            foreach (Point point in village.riverPoints)
            {
                VillageComponent villageComponent = ageOfVillagersForm.villageComponentFactory.getComponent("Water source", point);
                villageComponent.drawComponent(point, ageOfVillagersForm.graphics, ageOfVillagersForm.pen);
                ageOfVillagersForm.riverPoints.Add(point);
            }
        }
    }
}
