using System.Windows.Forms;
namespace ageOfVillagers
{
    internal class NationFactory
    {
        public static Shape GetNation(string currentNationName)
        {
            if (currentNationName == "Bangladeshi Farmer")
                return new BangladeshFactory();
            return null;
        }
    }
}