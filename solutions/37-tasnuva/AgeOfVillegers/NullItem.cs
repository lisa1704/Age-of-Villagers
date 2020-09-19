using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillegers
{
	internal class NullItem : IVillageItem
	{
		public void Draw(Point e, Graphics g, Pen p)
		{
			MessageBox.Show("please select a nation and an item first!");
		}
	}
}
