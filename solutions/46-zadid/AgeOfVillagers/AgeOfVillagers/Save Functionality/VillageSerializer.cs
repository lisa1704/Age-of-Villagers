using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AgeOfVillagers
{
    class VillageSerializer
    {
        Village _village;

        public void saveState(Village village)
        {
            _village = village;

            string villageSerialized = JsonConvert.SerializeObject(village);
            System.IO.File.WriteAllText("G:/C#/" + village.getName() + ".aov", villageSerialized);
            Debug.WriteLine(villageSerialized);
        }
    }
}
