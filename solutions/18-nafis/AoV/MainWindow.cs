using AoV.Shapes;
using AoV.Nations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = AoV.Shapes.Rectangle;

namespace AoV
{
    public partial class MainWindow : Form
    {
        string villageName;
        Color backGroundColor;
        string nationName;
        NationFactory nationType = new NationFactory();
        string itemName;
        List<Point> houseLocations = new List<Point>();
        List<Point> treeLocations = new List<Point>();
        List<Point> sourceLocations = new List<Point>();

        public MainWindow()
        {
            InitializeComponent();
        }
        #region ShapeDrawTest
        /// <summary>
        /// Test to see basic shapes were drawn
        /// </summary>
        /// 
        /*
        Graphics g;
        IShape myShape;
        public MainWindow()
        {
            InitializeComponent();
            g = DrawingPanel.CreateGraphics();
        }

        bool canPaint = false;
        int? pointX = null;
        int? pointY = null;

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            canPaint = true;

        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            canPaint = false;
            pointX = null;
            pointY = null;
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(canPaint)
            {

                //myShape = new Line(new Point(pointX ?? e.X, pointY ?? e.Y), new Point(e.X, e.Y));
                //myShape = new Triangle(new Point(pointX ?? e.X, pointY ?? e.Y), new Point(pointY ?? e.Y, e.X), new Point(e.X, pointX ?? e.X));
                //myShape = new Rectangle(new Point(pointX ?? e.X, pointY ?? e.Y), new Point(pointY ?? e.Y, e.X));
                //myShape = new Arc(20, 20, 100, 100, 0, 90);
                myShape = new Ellipse(new Point(pointX ?? e.X, pointY ?? e.Y), new Point(e.X, e.Y));
                myShape.Draw(g);
                pointX = e.X;
                pointY = e.Y;

            }

        }
        */
        #endregion

        private void btnHouse_CheckedChanged(object sender, EventArgs e)
        {
            itemName = "House";
        }

        private void btnTree_CheckedChanged(object sender, EventArgs e)
        {
            itemName = "Tree";
        }

        private void btnWater_CheckedChanged(object sender, EventArgs e)
        {
            itemName = "WaterSource";
        }

        private void NationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            nationName = NationList.Text;
            backGroundColor = nationType.GetNation(nationName).TerrainColor();
            DrawingPanel.BackColor = backGroundColor;
        }

        private void NewState_Click(object sender, EventArgs e)
        {
            houseLocations.Clear();
            treeLocations.Clear();
            sourceLocations.Clear();
            DrawingPanel.Refresh();
            NationList.ResetText();
            nationName = NationList.Text;
            DrawingPanel.BackColor = nationType.GetNation(nationName).TerrainColor();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = DrawingPanel.CreateGraphics();
            if (nationType.GetNation(nationName).getName() == "NullNation")
            {
                nationType.GetNation(nationName).DrawHouse(g, new Point(200, 200));
            }
            else
            {
                foreach (Point points in houseLocations)
                {
                    nationType.GetNation(nationName).DrawHouse(g, points);
                }

                foreach (Point points in treeLocations)
                {
                    nationType.GetNation(nationName).DrawTree(g, points);
                }

                foreach (Point points in sourceLocations)
                {
                    nationType.GetNation(nationName).DrawWaterSource(g, points);
                }
            }
        }

        private void DrawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (itemName == "House")
            {
                houseLocations.Add(e.Location);
            }
            if (itemName == "tree")
            {
                treeLocations.Add(e.Location);
            }
            if (itemName == "waterSource")
            {
                sourceLocations.Add(e.Location);
            }
            DrawingPanel.Invalidate();
        }

        private void VillageNameText_Enter(object sender, EventArgs e)
        {
            if (VillageNameText.Text == "Enter Village Name")
            {
                VillageNameText.Text = "";

                VillageNameText.ForeColor = Color.Black;
            }

        }

        private void VillageNameText_Leave(object sender, EventArgs e)
        {
            
            if (VillageNameText.Text == "")
            {
                VillageNameText.Text = "Enter Village Name";

                VillageNameText.ForeColor = Color.Silver;
            }
        }

        private void SaveState_Click(object sender, EventArgs e)
        {
            villageName = VillageNameText.Text;
            VillageNameText.Text = "Enter Village Name";
            VillageNameText.ForeColor = Color.Silver;
        }

    }
}
