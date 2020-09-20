using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageEditorWindow : Form
    {
        ArrayList listOfPoints;
        bool PencilDown;
        int x,y;
        string vname,item;
        public VillageEditorWindow()
        {
            InitializeComponent();
            listOfPoints = new ArrayList();
            PencilDown = false;
            this.ActiveControl = villagename;
            villagename.Focus();
        }

        private void drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point();
            x = p.X;
            y = p.X;
            
        }

        private void houseradio_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void treeradio_CheckedChanged(object sender, EventArgs e)
        {
            item = "Tree";
        }

        private void waterradio_CheckedChanged(object sender, EventArgs e)
        {
            item = "Water Resource";
        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {

        }

        private void titlelabel_Click(object sender, EventArgs e)
        {

        }

        private void toolpanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void drawingpanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

        }

        private void villagename_TextChanged(object sender, EventArgs e)
        {

        }

        private void nation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void drawingpanel_MouseDown(object sender, MouseEventArgs e)
        {
            PencilDown = true;
        }

        private void drawingpanel_MouseUp(object sender, MouseEventArgs e)
        {
            PencilDown = false;

        }


        private void drawingpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (PencilDown)
            {
                using (Graphics graphics = drawingpanel.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, 3, 3);
          
                }
            }

        }

        private void villagename_KeyDown(object sender, KeyEventArgs e)
        {
            vname = villagename.Text;

        }

        private void nation_KeyDown(object sender, KeyEventArgs e)
        {
            nation.Items.Add(nation);

        }

        private void savevillage_Click(object sender, EventArgs e)
        {
           
        }


        private void TreeRadioMouseClicked(object sender, MouseEventArgs e)
        {
            item = "Tree";

        }

        private void HouseRadioMouseClicked(object sender, MouseEventArgs e)
        {
            item = "House";

        }

        private void WaterSourceRadioMouseClicked(object sender, MouseEventArgs e)
        {
            item = "River";

        }

        private void newvillage_Click(object sender, EventArgs e)
        {
            drawingpanel.Invalidate();

        }
        private void openvillage_Click(object sender, EventArgs e)
        {
            drawingpanel.Invalidate();
        }


    }
}
