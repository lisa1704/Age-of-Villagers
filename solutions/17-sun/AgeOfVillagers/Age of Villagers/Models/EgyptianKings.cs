using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.Models
{
    class EgyptianKings : INation
    {
        private string nationName = "Egyptian Kings";
        private string inhabitedVillage;

        public void Draw_House()
        {
            throw new NotImplementedException();
        }

        public void Draw_Terrain()
        {
            throw new NotImplementedException();
        }

        public void Draw_Tree()
        {
            throw new NotImplementedException();
        }

        public void Draw_WaterSource()
        {
            throw new NotImplementedException();
        }

        public string Get_inhabitedVillage()
        {
            return inhabitedVillage;
        }

        public string Get_NationName()
        {
            return nationName;
        }

        public void Set_inhabitedVillage(string village)
        {
            this.inhabitedVillage = village;
        }
    }
}
