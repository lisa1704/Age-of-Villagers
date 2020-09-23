using Ageofvillagers.Nations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ageofvillagers
{
    public partial class Ageofvillagers : Form
    {
        INation nation = new NullNation();
        public Ageofvillagers()
        {

            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
    
}
