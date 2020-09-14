using AgeOfVillagers.Data_Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Tree
{
    public class TreeContext
    {
        public ITree _treetype;
        public Graphics _g;
        public Point _p;
        public ElementSize _sz;

        public TreeContext(ITree tree, Graphics g, Point p, ElementSize sz)
        {
            this._treetype = tree;
            this._g = g;
            this._p = p;
            this._sz = sz;
        }

        public void TreeDrawing()
        {
            _treetype.Draw(_sz, _g, _p);
        }
    }
}
