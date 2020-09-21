using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.Interface
{
    interface INation
    {
        public void setEnvironment(Label nation_Name, RadioButton firstNation, RadioButton secondNation, RadioButton thirdNation, RadioButton fourthNation, RadioButton tree, RadioButton house, RadioButton waterSource, Graphics graphics, string selectedNation, Color color);
        public void drawItem(Point point, string selectedItem, Graphics graphics, Pen pen,string selectedNation);

    }
}
