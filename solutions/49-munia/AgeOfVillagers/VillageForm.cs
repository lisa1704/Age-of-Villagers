using AgeOfVillagers.Nations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
   
    public partial class VillageForm : Form
    {
        public List<Point> P { get; set; } = new List<Point>();
        Point point;
        String nationName = " ";
        INation nation = new NullNation();
        INation nation2 = new NullNation();
        CheckNation checker = new CheckNation();
        public VillageForm()
        {
            InitializeComponent();
        }
        private void NationName_TextChanged(object sender, EventArgs e)
        {
            nationName = Text;
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
            P.Add(point);
            canvas.Invalidate();

        }
 private void NationChoose_SelectedIndexChanged(object sender, EventArgs e)
           {
            nation = checker.GetNation(NationChoose.Text);
            canvas.BackColor = nation.TerrainColor();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = canvas.CreateGraphics();        
            canvas.BackColor = nation.TerrainColor();

            if (tree.Checked == true)
            {
                nation.DrawTree(g, point);

            }
            else if (House.Checked == true)
            {
                nation.DrawHouse(g, point);

            }
            else if (Water.Checked == true)
            {
                nation.DrawWater(g, point);

            }

        }
        private void newVillage_MouseClick(object sender, MouseEventArgs e)
        {
            canvas.Invalidate();
        }

        private void NationChoose_DropDown(object sender, EventArgs e)
        {
            NationChoose.Items.Add("Bangladeshi Farmers");
            NationChoose.Items.Add("Arab Bedouin");
            NationChoose.Items.Add("Egyptian Kings");
            NationChoose.Items.Add("Inuit Hunters");
        }

        private void newVillage_Click(object sender, EventArgs e)
        {
            nation = nation2;
            tree.Checked = false ;
            House.Checked = false;
            Water.Checked = false;

        }
    }
}
