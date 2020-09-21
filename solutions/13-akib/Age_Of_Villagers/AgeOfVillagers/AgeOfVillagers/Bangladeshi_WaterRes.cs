using System;

namespace AgeOfVillagers

public class Bangladeshi_WaterRes : Water_Resource
{
	private int x_size = 24;
	private int y_size = 16;

	public void Create_WaterResource()
	{
		Lines bdw_line1 = new Lines(x, y+8, x, y+1);
		Lines bdw_line2 = new Lines(x, y+1, x+7, y+7);
		Lines bdw_line3 = new Lines(x+7, y+7, x+12, y+2);
		Lines bdw_line4 = new Lines(x+12, y+2, x+9, y-7);
		Lines bdw_line5 = new Lines(x+9, y-7, x+1, y-1);
		Lines bdw_line6 = new Lines(x+1, y-1, x-3, y-8);
		Lines bdw_line7 = new Lines(x-3, y-8, x-12, y-2);
		Lines bdw_line8 = new Lines(x-12, y-2, x-5, y+6);
		Lines bdw_line9 = new Lines(x-5, y+6, x, y+8);

		for(int i=1; i<10; i++)
        {
			bdw_linei.Draw_Shape();
        }
	}
}
