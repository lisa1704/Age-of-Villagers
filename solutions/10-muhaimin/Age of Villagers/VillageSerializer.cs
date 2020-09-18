using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    class VillageSerializer
    {
        protected Village villageState;
        public void saveState(Village village)
        {
            villageState = village;
            string villageSerialized = JsonConvert.SerializeObject(village);
            System.IO.File.WriteAllText(@"J:\" + village.getName() + ".aov", villageSerialized);
            Console.WriteLine(villageSerialized);
        }
    }
}
