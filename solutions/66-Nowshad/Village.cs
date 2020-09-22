using System;
using System.Collection.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Age_of_Villagers
{

	class Village
	{
		public string Name_of_Village = "untitled";
		public List<Axes> house = new List<Axes>();
		public List<Axes> tree = new List<Axes>();
		public List<Axes> water = new List<Axes>();
	}

}