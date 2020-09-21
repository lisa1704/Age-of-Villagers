using System;

public class Egyptian_Tree
{
	public void Create_Tree(int x, int y)
    {
        Lines et_line1 = new Lines(x, y, x+3, y+13);
        Lines et_line2 = new Lines(x, y, x-4, y+16);
        Lines et_line11 = new Lines(x+3, y+13, x+2, y+24);
        Lines et_line12 = new Lines(x+3, y+13, x+6, y+24);
        Lines et_line13 = new Lines(x+3, y+13, x+8, y+23);
        Lines et_line21 = new Lines(x-4, y+16, x-3, y+24);
        Lines et_line22 = new Lines(x-4, y+16, x-6, y+22);
        Lines et_line23 = new Lines(x-4, y+16, x-8, y+21);

        et_line1.Draw_Shape();
        et_line2.Draw_Shape();
        et_line11.Draw_Shape();
        et_line12.Draw_Shape();
        et_line13.Draw_Shape();
        et_line21.Draw_Shape();
        et_line22.Draw_Shape();
        et_line23.Draw_Shape();
    }
}
