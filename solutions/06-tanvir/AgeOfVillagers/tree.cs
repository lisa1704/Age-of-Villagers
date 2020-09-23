using System.Drawing;


namespace AgeOfVillagers
{


    public abstract class tree:IShape
    {

        protected Point p;
        protected int length,width;
        protected ShapeCombine sc = new ShapeCombine();
        public tree(Point p, int length,int width) 
        {
            this.p = p;
            this.l = length;
            this.w = width;
        }


        public abstract void DrawTree();

        public void Draw(Graphics grap, Pen pen)
        {
            
            this.DrawTree();
            sc.Draw(grap, pen);
        }   
    }



}