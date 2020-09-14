using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    class Village
    {
        public String VillageName;
        public List<(int, int)> houses = new List<(int, int)>();
        public List<(int, int)> trees = new List<(int, int)>();
        public List<(int, int)> water_resources = new List<(int, int)>();
    }
}