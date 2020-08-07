using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    interface IShapes
    {
        void Draw(Graphics g,int x, int y,int height,int width);
        Rectangle shape();
    }
}
