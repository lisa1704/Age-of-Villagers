using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofvillagers
{
   public  class abngladeshiwater : Shapecreate
    {
        public string draw(int x, int y)
        {

			
		{
			Linecreate line1 = new Linecreate(x, y + 8, x, y + 1);
			Linecreate line2 = new Linecreate(x, y + 1, x + 7, y + 7);
			Linecreate line3 = new Linecreate(x + 7, y + 7, x + 12, y + 2);
			Linecreate line4 = new Linecreate(x + 12, y + 2, x + 9, y - 7);
			Linecreate line5 = new Linecreate(x + 9, y - 7, x + 1, y - 1);
			Linecreate line6 = new Linecreate(x + 1, y - 1, x - 3, y - 8);
			Linecreate line7 = new Linecreate(x - 3, y - 8, x - 12, y - 2);
			Linecreate line8 = new Linecreate(x - 12, y - 2, x - 5, y + 6);
			Linecreate line9 = new Linecreate(x - 5, y + 6, x, y + 8);

			line1.Draws();
		    line2.Draws();
			 line3.Draws();
		    line4.Draws();
			 line5.Draws();
			 line6.Draws();
			line7.Draws();
			 line8.Draws();
			line9.Draws();

			return "null";
		}
    }
}
