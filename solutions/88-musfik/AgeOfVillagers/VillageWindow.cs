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
    public partial class VillageWindow : Form
    {
        int x;
        int y;
        Graphics g;
        public Pen p; 
        string text = null;

        public VillageWindow()
        {
            InitializeComponent();
        }

        private void drawing_space_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void drawing_space_MouseClick(object sender, MouseEventArgs e)
        {
            
            //Point point3 = new Point(e.X, e.Y);
            //Point point1 = new Point(e.X-30, e.Y+30);
            //Point point2 = new Point(e.X+30, e.Y+60);

            Point point = new Point(e.X, e.Y);
            IShape bShape = new BangladeshiHouse(new Point(point.X+20, point.Y));
            //IShape aShape = new ArabBedouinHouse(new Point(point.X - 20, point.Y));
            IShape iShape = new BangladeshiTree(point);

            bShape.Draw(g, p);
            //aShape.Draw(g, p);
            iShape.Draw(g, p);


        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {
            g = drawing_space.CreateGraphics();
            p = new Pen(Color.Black);      
        }

        private void Village_name_textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            text = objTextBox.Text;
        }

        private void NationlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void new_village_btn_Click(object sender, EventArgs e)
        {

        }

        private void save_village_btn_Click(object sender, EventArgs e)
        {

        }

        private void open_village_btn_Click(object sender, EventArgs e)
        {

        }

        private void House_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tree_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void water_btn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
