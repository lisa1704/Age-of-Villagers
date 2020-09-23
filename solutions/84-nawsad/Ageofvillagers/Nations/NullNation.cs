using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ageofvillagers.Nations
{
    class NullNation:INation
    {
        Graphics g;
        Pen p;
        public readonly String Name = "Null";
        public NullNation()
        {
            
        }
        public string get_nation()
        {
            return Name;
        }
        public String drawHouse(int x, int y)
        {
            return "No House";
        }

        public String drawTree(int x, int y)
        {
            return "No Tree";
        }

        public String drawWaterSource(int x, int y)
        {
            return "No Water Source";
        }
      
    }
}
