using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Ageofvillagers;
using Ageofvillagers.Nations;

namespace Ageofvillagers
{
    public partial class Ageofvillagers :Form
    {  
        public int mousepositionx;
        public int mousepositiony;
        public List<State> Itemslist = new List<State>();
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            mousepositionx = e.Location.X;
            mousepositiony = e.Location.Y;
            if (Item_type == "House")
            {
                nation.drawHouse(mousepositionx, mousepositiony);
                Itemslist.Add(new State(mousepositionx, mousepositiony, "House",nation.get_nation()));
                
                foreach (var a in Itemslist)
                {
                   Console.WriteLine(a.Itemx);
                    Console.WriteLine(a.Itemy);
                    Console.WriteLine(a.Item_name);
                    Console.WriteLine(a.Nation_Name);
                    nation.drawHouse(a.Itemx + 10, a.Itemy + 10);

                }
                
                
                  
            }
            else if (Item_type == "Tree")
            {
                nation.drawTree(mousepositionx,mousepositiony);

            }
            else if(Item_type=="Water Source")
            {
                nation.drawWaterSource(mousepositionx,mousepositiony);
            }
          
        
            
            //INation Nation = new EgyptianKing(g,p);
            //Nation.drawHouse(e.Location.X, e.Location.Y);
            //  B.drawHouse(e.Location.X, e.Location.Y);

        }
    }
}
