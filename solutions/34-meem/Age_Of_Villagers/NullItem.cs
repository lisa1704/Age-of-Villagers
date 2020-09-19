using System.Drawing;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
    internal class NullItem : IVillageItem
    {
        public void Draw(Point e, Graphics g, Pen p)
        {
            MessageBox.Show("please select a nation and an item first!");
        }
    }
}