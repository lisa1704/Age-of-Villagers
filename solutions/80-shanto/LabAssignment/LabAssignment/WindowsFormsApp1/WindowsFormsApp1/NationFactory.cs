using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1_Test
{
     public class NationFactory
    {
        public readonly Graphics g;
        public NationFactory(Graphics g)
        {
            this.g = g;
        }

        public INation GetNation(string NationType)
        {
            if (NationType == "Bangladeshi Farmers")
            {
                return new BangladeshiFarmers(g);
            }
            else if (NationType == "Arab Bedouin")
            {
                return new ArabBedouin(g);
            }
            else if (NationType == "Egypt Kings")
            {
                return new EgyptianKing(g);
            }
            else if (NationType == "Inuit Hunters")
            {
                return new InuitHunters(g);
            }
            throw new Exception();

        }
    }

    class NationManager
    {
        private readonly string Nation;
        private readonly NationFactory nationFactory;

        public NationManager(string Nation, NationFactory nationFactory)
        {
            this.Nation = Nation;
            this.nationFactory = nationFactory;
        }

        public void DrawHouse(MouseEventArgs e)
        {
            INation nation = nationFactory.GetNation(Nation);
            nation.DrawHouse(e);
        }
        public void DrawTree(MouseEventArgs e)
        {
            INation nation = nationFactory.GetNation(Nation);
            nation.DrawTree(e);
        }
        
        public void DrawWaterSource(MouseEventArgs e)
        {
            INation nation = nationFactory.GetNation(Nation);
            nation.DrawWaterSource(e);
        }

    }
}
