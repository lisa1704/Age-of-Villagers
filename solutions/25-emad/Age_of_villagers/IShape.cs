using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_villagers
{
    public interface IShape
    {
        public void draw(Point p, Graphics g);
        public void draw(Point p, Graphics graphics);
    }
}