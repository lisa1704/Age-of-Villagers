using System;

namespace AgeOfVillagers

public class Arab_Tree : I_Shape
{
	public void Create_Tree(int x, int y)
    {
        Rectangle at_rectangle = new Rectangle(x + 1, y, x + 1, y - 12, x - 1, y - 12, x - 1, y);
        Lines at_line1 = new Lines(x, y, x, y+12);
        Lines at_line2 = new Lines(x, y, x+8, y+3);
        Lines at_line3 = new Lines(x, y, x-8, y+3);
        Lines at_line4 = new Lines(x, y, x+5, y+8);
        Lines at_line5 = new Lines(x, y, x-5, y+8);

        at_rectangle.Draw_Shape();
        at_line1.Draw_Shape();
        at_line2.Draw_Shape();
        at_line3.Draw_Shape();
        at_line4.Draw_Shape();
        at_line5.Draw_Shape();
    }
}
