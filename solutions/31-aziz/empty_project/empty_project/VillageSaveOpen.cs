using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Newtonsoft.Json;

namespace empty_project
{
    class VillageSaveOpen
    {
        protected Village villageState;
        protected string villageSerialized;

        public VillageSaveOpen(Village village)
        {
            villageState = village;
        }
        public void saveVillage(Village village)
        {
            villageState = village;
            villageSerialized = JsonConvert.SerializeObject(villageState);
        }
    }
}
