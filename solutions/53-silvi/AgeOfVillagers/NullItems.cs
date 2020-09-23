using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class NullItems : Composite
    {
        public void drawing()
        {
            MessageBox.Show("please select a nation and an item first!");
        }
    }
}