using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_of_villagers
{
    class Save_village
    {
        Village villagename;

        public void save(Village village)
        {
            villagename = village;

            string villageSerialized = JsonConvert.SerializeObject(village);
            System.IO.File.WriteAllText("E:/Villages/" + village.getName() + ".aov", villageSerialized);
            Debug.WriteLine(villageSerialized);
        }
    }
}
