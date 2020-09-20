using System;
using System.Collections.Generic;
using System.Text;

namespace Age_of_Villagers.Models
{
    interface INation
    { 
        void Draw_House();
        void Draw_Tree();
        void Draw_WaterSource();
        void Draw_Terrain();

        string Get_inhabitedVillage();

        void Set_inhabitedVillage(string village);

        string Get_NationName();
       

    }
}
