using System;

public class Inuithouse : IShape
{
    
        
     public void Draw(int x, int y)
     {
        HalfCircle Ehcircle = new HalfCircle(x, y, 6);

        Ehcircle.Draw();

        HalfCircle Ehcircle2 = new HalfCircle2(x, y, 4);

        Ehcircle2.Draw();
    }
    
}



