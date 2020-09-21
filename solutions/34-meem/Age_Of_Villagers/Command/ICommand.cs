using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
    public interface ICommand
    {
        void execute();
    }

    public struct Village
    {
        public string villageName;
        public List<Point> housePoints;
        public List<Point> treePoints;
        public List<Point> waterSourcePoints;


    }


}
    