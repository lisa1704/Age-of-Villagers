﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.Models
{
    class ArabBedouins : INation
    {
        private string nationName = "Arab Bedouins";
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
