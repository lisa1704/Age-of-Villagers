using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ageofvillagers
{
    interface INation
    {
        String drawHouse(int x,int y);
        String drawTree(int x,int y);
        String drawWaterSource(int x,int y);
        String get_nation();
    }
}
