using System.Drawing;

namespace AgeOfVillagers90
{
    public class NullNation : INation
    {
        public Color BackGroundColor()
        {
            return Color.White;
        }

        public object DrawHouse(Graphics g, Point pt)
        {
            NullVillageItem NullNationhouse = new NullVillageItem();
            NullNationhouse.paint();
            return NullNationhouse;
        }

        public object DrawTree(Graphics g, Point pt)
        {
            NullVillageItem NullNationtree = new NullVillageItem();
            NullNationtree.paint();
            return NullNationtree;
        }

        public object DrawWaterSource(Graphics g, Point pt)
        {
            NullVillageItem NullNationws = new NullVillageItem();
            NullNationws.paint();
            return NullNationws;
        }
    }
}
