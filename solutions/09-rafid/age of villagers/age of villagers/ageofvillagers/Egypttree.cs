using System;

public class Egypttree : IShape
{
    

    public void draw(int x, int y)
    {
        Lines etline1 = new Lines(x, y, x + 3, y + 13);
        etline1.Draw();

        Lines etline2 = new Lines(x, y, x - 4, y + 16);
        etline2.Draw();

        Lines etline3 = new Lines(x + 3, y + 13, x + 2, y + 24);
        etline3.Draw();

        Lines etline4 = new Lines(x + 3, y + 13, x + 6, y + 24);
        etline4.Draw();

        Lines etline5 = new Lines(x + 3, y + 13, x + 8, y + 23);
        etline5.Draw();

        Lines etline6 = new Lines(x - 4, y + 16, x - 3, y + 24);
        etline6.Draw();

        Lines etline7 = new Lines(x - 4, y + 16, x - 6, y + 22);
        etline7.Draw();

        Lines etline8 = new Lines(x - 4, y + 16, x - 8, y + 21);
        etline8.Draw();


    }
}
