using System;
using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillagers
{
	public interface INation
	{
		
		public void DrawHouse(Point p, Panel drawingBoard);
		public void DrawTree(Point p, Panel drawingBoard);
		public void DrawWaterSource(Point p, Panel drawingBoard);
	}
}