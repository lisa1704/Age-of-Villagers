﻿using System;

public class Triangle : Shape
{
    private int x1, y1, x2, y2, x3, y3;
    public Lines(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        this.x1 = x1;
        this.x2 = x2;
        this.x3 = x3;
        this.y1 = y1;
        this.y2 = y2;
        this.y3 = y3;


    }
    public string Draw()
    {
        return "Drawing a triangle";
    }

}
