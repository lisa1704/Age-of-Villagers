using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AgeOfVillegers 


{
	public interface INation
	{
		Color get_backcolor();
		IObject Draw_house(Point p);
		IObject Draw_tree(Point p);
		IObject Draw_watersource(Point p);
	}
}
