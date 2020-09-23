using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    public abstract class house:IShape
    {
        protected Point p;
        protected int length, width;
        protected ShapeCombine sc = new ShapeCombine();

    }
}