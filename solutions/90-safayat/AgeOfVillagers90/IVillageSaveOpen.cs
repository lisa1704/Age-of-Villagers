using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers90
{
    interface IVillageSaveOpen
    {
        void execute();
    }

    public struct VillageItem
    {
        public string NameofVillage;
        public List<Point> PointHouse;
        public List<Point> PointTree;
        public List<Point> PointWaterSource;
    }
}
