using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AgeOfVillegers
{
	public class  village 
	{
		public string name;
		public List<Point> house_point;
		public List<Point> tree_point;
		public List<Point> waterresource_point;
		public village(string name, List<Point> house_point, List<Point> tree_point, List<Point> waterresource_point)
		{
			this.name = name;
			this.house_point = house_point;
			this.tree_point = tree_point;
			this.waterresource_point = waterresource_point;
		}
	}
}
