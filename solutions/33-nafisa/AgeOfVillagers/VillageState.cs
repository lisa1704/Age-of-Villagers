using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class VillageState : ISnapState
    {
        private string village_name;
        private string nation_name;
        private List<Point> house_locations = new List<Point>();
        private List<Point> tree_locations = new List<Point>();
        private List<Point> watersource_locations = new List<Point>();

        public VillageState(String village_name, string nation_name, List<Point> house_locations, List<Point> tree_locations, List<Point> watersource_locations)
        {
            this.village_name = village_name;
            this.nation_name = nation_name;
            this.house_locations = house_locations;
            this.tree_locations = tree_locations;
            this.watersource_locations = watersource_locations;
        }

        public List<Point> getHouseState()
        {
            return house_locations;
        }

        public List<Point> getTreeState()
        {
            return tree_locations;
        }

        public List<Point> getWsourceState()
        {
            return watersource_locations;
        }

        public void setHouseState(Point point)
        {
            house_locations.Add(point);

        }     
       
        public void setTreeState(Point point)
        {
            tree_locations.Add(point);

        }

        public void setWsourceState(Point point)
        {
            watersource_locations.Add(point);
        }
    }
}
