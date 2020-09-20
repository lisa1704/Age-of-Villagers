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
        public int x,y;
        public string vname,item;
        public INation _nation;
        public Graphics gr;

        public VillageEditorWindow()
        {
            InitializeComponent();
            listOfPoints = new ArrayList();
            PencilDown = false;
            this.ActiveControl = villagename;
            gr = drawingpanel.CreateGraphics();
            
        }

        public void drawingpanel_MouseClick(object sender, MouseEventArgs e)
        {
            //Point p = new Point();
            x = e.X;
            y = e.X;
            Pen pen = new Pen(Color.Blue);
            NationFactory NaFact = new NationFactory(nation.Text);

            if(item == "Tree")
            {
                NaFact.GetNation().DrawTree(new Point(x, y)).DrawShapes(gr, pen);

            }
            
        }

        private void houseradio_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void treeradio_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void waterradio_CheckedChanged(object sender, EventArgs e)
        {
        
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


        public void drawingpanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = drawingpanel.CreateGraphics();
            Pen p = new Pen(Color.Black);

        }

        private void villagename_TextChanged(object sender, EventArgs e)
        {

        }

        public void nation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void drawingpanel_MouseDown(object sender, MouseEventArgs e)
        {
            PencilDown = true;
        }

        public void drawingpanel_MouseUp(object sender, MouseEventArgs e)
        {
            PencilDown = false;

        }


        public void drawingpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (PencilDown)
            {
                using (Graphics graphics = drawingpanel.CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, 3, 3);
          
                }
            }

        }

        public void villagename_KeyDown(object sender, KeyEventArgs e)
        {
            vname = villagename.Text;

        }

        private void savevillage_Click(object sender, EventArgs e)
        {
           
        }


        public void TreeRadioMouseClicked(object sender, MouseEventArgs e)
        {
            item = "Tree";

        }

        public void HouseRadioMouseClicked(object sender, MouseEventArgs e)
        {
            item = "House";

        }

        public void WaterSourceRadioMouseClicked(object sender, MouseEventArgs e)
        {
            item = "River";

        }

        public void newvillage_Click(object sender, EventArgs e)
        {
            drawingpanel.Invalidate();

        }
        public void openvillage_Click(object sender, EventArgs e)
        {
            drawingpanel.Invalidate();
        }


    }
}
