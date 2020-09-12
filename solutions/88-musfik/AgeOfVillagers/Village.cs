using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public interface INation
    {
        Color getTerrainColor();
        string getNationName();
        Object getTree(Point point);
        Object getHouse(Point point);
        Object getWaterResource(Point point);
    }
    public interface INationFactory
    {
        INation getNation();
    }
    public class Village
    {
        private string villageName;
        private INation nation;
        private List<Object> Houses, Trees, waterResources;
        public Village(string villageName, INation nation)
        {
            this.villageName = villageName;
            this.nation = nation;
            Trees = new List<Object>();
            Houses = new List<Object>();
            waterResources = new List<Object>();
        }

        public string GetVillageName()
        {
            return villageName;
        }

        public void SetVillageName(string value)
        {
            villageName = value;
        }
    }
}
