using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    public interface IShapes
    {
        void Draw(Graphics g);
        Rectangle GetBBox();
    }



}
