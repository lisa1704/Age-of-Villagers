using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Age_of_villagers
{
    public interface IObject
    {
        void paint(Pen p,Graphics g);
    }
}
