using System.Windows.Forms;

namespace Age_of_Villagers
{
    internal interface IElement
    {
        void draw(Axis axes, Panel panel);
    }
}