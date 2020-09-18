using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public interface IStatesVillage
    {
        void executeAction();
    }

    public struct VillageProperties
    {
        public string name;
        public List<Point> House_point;
        public List<Point> Tree_point;
        public List<Point> Waterresource_point;
    }
}
