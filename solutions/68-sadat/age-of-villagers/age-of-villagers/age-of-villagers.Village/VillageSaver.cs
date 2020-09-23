using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace age_of_villagers.age_of_villagers.Village
{
    class VillageSaver
    {
        protected Village villageState;
        public void saveVillageState(Village village)
        {
            villageState = village;
            string saveVillage = JsonConvert.SerializeObject(village);
            System.IO.File.WriteAllText(@"E:\" + village.getName() + ".aov", saveVillage);
            Console.WriteLine(saveVillage);
        }
    }
}
