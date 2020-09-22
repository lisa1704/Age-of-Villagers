using System;
using System.Drawing;
using System.Windows.Forms;

namespace ageOfVillagers
{
    internal class BackgroundColor
    {
        public void GetBackgroundColor(string currentNationName, Panel panel)
        {
            if (currentNationName == "Bangladeshi Farmer")
            {
                panel.BackColor = Color.Green;
            }
            else if (currentNationName == "Arab Bedouin")
            {
                panel.BackColor = Color.LightYellow;
            }
            else if (currentNationName == "Egyptian Kings")
            {
                panel.BackColor = Color.Yellow;
            }
            else if (currentNationName == "Inuit Hunters")
            {
                panel.BackColor = Color.White;
            }
            else
                throw new NotImplementedException();
        }
    }
}