using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Of_Villagers
{
    public interface INations
    {
        void DrawTree(Graphics g,int x,int y);
      void DrawHouse(Graphics g,int x,int y);
       void DrawWaterSource(Graphics g);
       void SetBackground(Graphics g); 
        void SetWaterSource();
        string getNationName();

      







    }
}
