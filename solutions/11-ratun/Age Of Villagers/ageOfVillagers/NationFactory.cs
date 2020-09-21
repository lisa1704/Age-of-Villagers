using System.Windows.Forms;

namespace ageOfVillagers
{
    interface IDraw
    {
        void Draw(string nationName, string currentselect, int x, int y);
    }
    public class NationFactory : IDraw
    {
        public void Draw(string nationName, string currentselect, int x, int y)
        {

        }
    }
}