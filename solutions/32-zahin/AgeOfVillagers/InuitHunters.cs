using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class InuitHunters : INation
    {
        private string item;

        public InuitHunters()
        {

        }

        void INation.DrawHouse(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }

        void INation.DrawTree(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }

        void INation.DrawWaterSource(Graphics g, Point point)
        {
            throw new NotImplementedException();
        }
    }
}
