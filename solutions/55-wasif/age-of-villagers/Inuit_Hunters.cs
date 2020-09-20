using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_of_villagers
{
    class Inuit_Hunters : INations
    {
        public void draw_house()
        {
            throw new NotImplementedException();
        }

        public void draw_tree()
        {
                MessageBox.Show("Inuit Hunters can not plant trees");
        }

        public void draw_watersource()
        {
            throw new NotImplementedException();
        }
    }
}
