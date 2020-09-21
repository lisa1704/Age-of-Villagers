using System.Windows.Forms;
namespace ageOfVillagers
{
    internal class NationFactory
    {
        public static Shape GetNation(string currentNationName)
        {
            if (currentNationName == "Bangladeshi Farmer")
                return new BangladeshFactory();
            else if (currentNationName == "Arab Bedouin")
                return new ArabFactory();
            else if (currentNationName == "Egyptian Kings")
                return new EgyptFactory();
            else if (currentNationName == "Inuit Hunters")
                return new InuitFactory();
            return null;
        }
    }
}