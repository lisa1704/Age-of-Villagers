using System;
using System.Collections.Generic;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
     public class Village
    {
        public string villageName;
        
     
        public List<Point> housePosition,waterSoucePosition;
        public List<Point> treePosition;
        public Village()
        {
            housePosition = new List<Point>();
            treePosition = new List<Point>();
            waterSoucePosition = new List<Point>();
        }


        public string VillageName { get => villageName; set => villageName = value; }

        public void OpenVillage(Village village, Nation nation,Graphics g)
        {
            try
            {

                nation.SetBackground(g);



                // Draw village items from saved item position in the village object


                village.housePosition.ForEach(house => nation.DrawHouse(g, house));
                village.treePosition.ForEach(tree => nation.DrawTree(g, tree));
                village.waterSoucePosition.ForEach(waterSource => nation.DrawWaterSource(g, waterSource));


            }
            catch (Exception e)
            {
                string message = "Select Nation to Open The Village";
                MessageBox.Show(message);






            }





        }




    }
}
