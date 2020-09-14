using AgeOfVillagers.House;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;


namespace AgeOfVillagers
{
    public class Village
    {
        public string villageName;
        public List<Point> housePosition,treePosition;

        public Village()
        {
            housePosition = new List<Point>();
            treePosition = new List<Point>();
        }

        public string getName()
        {
            return villageName;
        }
        
        public void setName(string name)
        {
            villageName = name;
        }
    }
}
