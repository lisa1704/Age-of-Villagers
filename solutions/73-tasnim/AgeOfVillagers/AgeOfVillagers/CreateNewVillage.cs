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
    public partial class CreateNewVillage : Form
    {
        Graphics g;
        string nationType = "";
        List<Point> HousePoints = new List<Point>();
        FactoryNation Inputnation = new FactoryNation();
        public CreateNewVillage()
        {
            InitializeComponent();
        }

        private void Tree_Click(object sender, EventArgs e)
        {

        }

        private void House_Click(object sender, EventArgs e)
        {

        }

        private void Water_Source_Click(object sender, EventArgs e)
        {

        }

        private void Select_Nation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw_Panel.BackColor = Inputnation.NationType(Select_Nation.Text).Color_Terrain();
        }

        private void Village_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Village_Click(object sender, EventArgs e)
        {

        }

        private void New_Village_Click(object sender, EventArgs e)
        {

        }

        private void Open_Village_Click(object sender, EventArgs e)
        {

        }

        private void Draw_Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Draw_Panel.CreateGraphics();
            Pen p = new Pen(Color.Black);

            foreach (Point pt in HousePoints)
            {
                nationType = Select_Nation.Text;
                //g.DrawLine(p, pt.X, pt.Y, 100, 100);
                Inputnation.NationType(nationType).Draw_House(g, pt);

            }

        }

        private void Draw_Panel_MouseClick(object sender, MouseEventArgs e)
        {
            HousePoints.Add(e.Location);
            Draw_Panel.Invalidate();

        }
    }
}
