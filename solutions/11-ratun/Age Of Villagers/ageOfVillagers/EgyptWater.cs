﻿namespace ageOfVillagers
{
    internal class EgyptWater : IShape
    {
        private int Xaxis = 16;
        private int Yaxis = 16;
        public string draw(int x, int y)
        {
            Circle c = new Circle(x, y, 8);
            return c.Draw();
        }
    }
}