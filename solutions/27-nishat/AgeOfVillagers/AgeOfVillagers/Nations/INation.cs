using System;
using System.Drawing;

namespace AgeOfVillagers
{
    public interface INation
    {
        String GetNationName();

        Color GetTerrainColor();

        VillageItem GetTree(Point point);

        VillageItem GetHouse(Point point);

        VillageItem GetWaterResource(Point point);
    }
}
