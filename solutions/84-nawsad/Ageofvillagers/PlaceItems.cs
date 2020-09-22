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
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            mousepositionx = e.Location.X;
            mousepositiony = e.Location.Y;
            if (Item_type == "House")
            {
                nation.drawHouse(mousepositionx, mousepositiony);
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
