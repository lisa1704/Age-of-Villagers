using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    interface ICommands
    {
        void executeSave();
    }

    public struct VillageProperties
    {
        public string name;
        public List<Point> house_point;
        public List<Point> tree_point;
        public List<Point> waterresource_point;
    }

    public class SaveVillage : ICommands
    {
        public void executeSave()
        {
            throw new NotImplementedException();
        }
    }
}
