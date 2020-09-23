﻿using System;

public class Arabtree : IShape
{
    public void draw(int x, int y)
    {
        Rectangle arabt_rectangle = new Rectangle(x + 1, y, x + 1, y - 12, x - 1, y - 12, x - 1, y);
        arabt_rectangle.Draw();

        Lines arabt_line_1 = new Lines(x, y, x, y + 12);
        arabt_line_1.Draw();

        Lines arabt_line_2 = new Lines(x, y, x + 8, y + 3);
        arabt_line_2.Draw();

        Lines arabt_line_3 = new Lines(x, y, x - 8, y + 3);
        arabt_line_3.Draw();

        Lines arabt_line_4 = new Lines(x, y, x + 5, y + 8);
        arabt_line_4.Draw();

        Lines arabt_line_5 = new Lines(x, y, x - 5, y + 8);
        arabt_line_5.Draw();


    }
}
