using System.Drawing;
using System.Windows.Forms;
namespace ageOfVillagers
{
    internal class NationFactory
    {
        public static Shape GetNation(string currentNationName, Panel panel)
        {
            if (currentNationName == "Bangladeshi Farmer")
            {
                panel.BackColor = Color.Green;
                return new BangladeshFactory();
            }
            else if (currentNationName == "Arab Bedouin")
            {
                panel.BackColor = Color.LightYellow;
                return new ArabFactory();
            }
            else if (currentNationName == "Egyptian Kings")
            {
                panel.BackColor = Color.Yellow;
                return new EgyptFactory();
            }
            else if (currentNationName == "Inuit Hunters")
            {
                panel.BackColor = Color.White;
                return new InuitFactory();
            }
            return null;
        }
    }
}