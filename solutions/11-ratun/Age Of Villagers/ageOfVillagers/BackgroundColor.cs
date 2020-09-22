using System;
using System.Drawing;
using System.Windows.Forms;

namespace ageOfVillagers
{
    internal class BackgroundColor
    {
        string color;
        public string GetBackgroundColor(string currentNationName, Panel panel)
        {
            if (currentNationName == "Bangladeshi Farmer")
            {
                panel.BackColor = Color.Green;
                color = "Green";
            }
            else if (currentNationName == "Arab Bedouin")
            {
                panel.BackColor = Color.LightYellow;
                color = "light yellow";
            }
            else if (currentNationName == "Egyptian Kings")
            {
                panel.BackColor = Color.Yellow;
                color = "yellow";
            }
            else if (currentNationName == "Inuit Hunters")
            {
                panel.BackColor = Color.White;
                color = "white";
            }
            else
            {
                //throw new NotImplementedException();
                color = "null";
            }
            return color;
        }
    }
}