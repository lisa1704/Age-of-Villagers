using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Villagers
{
    interface IShape
    {
        void draw(Graphics g, Pen pen);
    }

    class nullshape : IShape
    {
        private static IShape _instance;
        private nullshape()
        { }
        public void draw(Graphics g, Pen pen)
        { }
        public static IShape Instance
        {
            get
            {
                if (_instance == null)
                    _instance= new nullshape();
                return _instance;
            }
        }
    }
}
