using System.Drawing;


namespace Age_of_Villagers
{
    public abstract class tree:IShape
    {
        protected Point p;
        protected int length,width;
        protected compositeShape cs = new compositeShape();
        public tree(Point p, int length,int width) 
        {
            this.p = p;
            this.length = length;
            this.width = width;
        }

        public abstract void createTree();

        public void draw(Graphics g, Pen pen)
        {
            this.createTree();
            cs.draw(g, pen);
        }   
    }
}
