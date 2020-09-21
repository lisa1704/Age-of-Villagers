using System;

public class Bdtree : Tree
{
	public void CreateTree(int x, int y)
    {
        Circle c=new Circle(x,y+2,8);
        c.Draw();
        Rectangle r= new Rectangle(x-1,y,x+1,y,x+1,y-12,x-1,y-12);
        r.Draw();
    }
}
