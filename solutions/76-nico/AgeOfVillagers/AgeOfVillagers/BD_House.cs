using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeOfVillagers
{
    class BD_House:CompositeShape 
    {
        public BD_House(Point top, Point topleft, Point bottomright)
        {
            AddComponent(new Rectangle(topleft, bottomright));
            AddComponent(new Triangle(top, topleft, new Point(bottomright.X, topleft.Y)));
        }
    }
}
