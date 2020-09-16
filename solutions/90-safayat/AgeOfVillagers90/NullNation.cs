using System.Drawing;

namespace AgeOfVillagers90
{
    class NullNation : INation
    {
        public Color BackGroundColor()
        {
            return Color.White;
        }

        public void DrawHouse(Graphics g, Point pt)
        {
            NullVillageItem NullNationhouse = new NullVillageItem();
            NullNationhouse.paint();
        }

        public void DrawTree(Graphics g, Point pt)
        {
            NullVillageItem NullNationtree = new NullVillageItem();
            NullNationtree.paint();
        }

        public void DrawWaterSource(Graphics g, Point pt)
        {
            NullVillageItem NullNationws = new NullVillageItem();
            NullNationws.paint();
        }
    }
}
