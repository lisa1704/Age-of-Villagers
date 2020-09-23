using System;

public class Egypttree : IShape
{
    private string draw = "";

    public string draw(int x, int y)
    {
        Lines etline1 = new Lines(x, y, x + 3, y + 13);
        draw = draw + etline1.Draw_Shape();

        Lines etline2 = new Lines(x, y, x - 4, y + 16);
        draw = draw + etline2.Draw_Shape();

        Lines etline3 = new Lines(x + 3, y + 13, x + 2, y + 24);
        draw = draw + etline3.Draw_Shape();

        Lines etline4 = new Lines(x + 3, y + 13, x + 6, y + 24);
        draw = draw + etline4.Draw_Shape();

        Lines etline5 = new Lines(x + 3, y + 13, x + 8, y + 23);
        draw = draw + etline5.Draw_Shape();

        Lines etline6 = new Lines(x - 4, y + 16, x - 3, y + 24);
        draw = draw + etline6.Draw_Shape();

        Lines etline7 = new Lines(x - 4, y + 16, x - 6, y + 22);
        draw = draw + etline7.Draw_Shape();

        Lines etline8 = new Lines(x - 4, y + 16, x - 8, y + 21);
        draw = draw + etline8.Draw_Shape();

        return draw;
    }
}
