using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_villagers
{
    public class NullNation : INation
    {
        public IObject Draw_house(Point p)
        {
            warning();
            return null_obj.Instance;
        }

        public IObject Draw_tree(Point p)
        {
            warning();
            return null_obj.Instance;
        }

        public IObject Draw_watersource(Point p)
        {
            warning();
            return null_obj.Instance;
        }

        public Color get_backcolor()
        {
            return Color.White;
        }

        public void warning()
        {
            DialogResult d;
            d = MessageBox.Show("VillgeType is not selected");
        }
    }
}
