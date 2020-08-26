using System.Drawing;

namespace AgeOfVillagers
{
    public class Village
    {
        private INation nation;
        private string villagename;

        public Village(INation nation, string villagename)
        {
            this.nation = nation;
            this.villagename = villagename;
        }

        internal void initiate(Graphics g)
        {
            g.Clear(nation.GetTerrainColor());
        }
    }
}
