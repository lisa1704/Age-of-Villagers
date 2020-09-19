using Microsoft.Office.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers.Age_of_Villagers
{
    class Village
    {
        public string villageName = "untitled";
        public List<Axes> houses = new List<Axes>();
        public List<Axes> trees = new List<Axes>();
        public List<Axes> waterS = new List<Axes>();
    }
}
