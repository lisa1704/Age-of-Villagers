using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillagers
{
	public interface INation
	{
		public IShape DrawHouse(Point p);
		public IShape DrawTree(Point p);
		public IShape DrawWaterSource(Point p);
		public Color PaintTerrain(Point p);
	}
}