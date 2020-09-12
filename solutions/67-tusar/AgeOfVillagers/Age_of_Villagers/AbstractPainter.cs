using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    abstract class AbstractPainter : IPainter
    {
        List<IElement> elements = new List<IElement>();
        public void draw()
        {
            throw new NotImplementedException();
        }
    }
}
