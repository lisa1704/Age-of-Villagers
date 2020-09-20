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
    public partial class Form1 : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving=false;
        Pen pen;
        private string _villagename, _nationame;
        private NationManager _nationmanager;

        VillageState _villagestate;
        private string name;

        private List<Point> Housepoints { get; set; } = new List<Point>();
        private List<Point> Waterpoints { get; set; } = new List<Point>();
        private List<Point> Treepoints { get; set; } = new List<Point>();
       
        IGraphicShape _shape;
        public void get_state()
        {
            this._villagestate = new VillageState(VillageName.Text, Housepoints, Treepoints, Waterpoints);
        }


        public Form1()
        {
            InitializeComponent();

            g = DrawPanel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 2);

        }


        private void NewVillagebtn_Click(object sender, EventArgs e)
        {
            Form vlgname = new VillageNameInput(this,DrawPanel);
            
            Housepoints.Clear();
            Treepoints.Clear();
            Waterpoints.Clear();
            DrawPanel.Invalidate();
            vlgname.Show();

        }


        private void SaveVillagebtn_Click(object sender, EventArgs e)
        {
            get_state();
            SaveVillageState command = new SaveVillageState(_villagestate);
            command.Execute();
            MessageBox.Show("Village Saved");

        }

     public void setState(VillageState village)
        {
            NationManager manager = new NationManager(NationName.Text);


            foreach (Point pt in village._housePoints)
            {
                manager.getNation(pt).GetHouse().draw(g, pen);
            }
            foreach (Point pt in village._treePoints)
            {
                manager.getNation(pt).GetTrees().draw(g, pen);
            }
            foreach (Point pt in village._WaterScPoints)
            {
                manager.getNation(pt).GetWaterSources().draw(g, pen);
            }
        }






        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            Point _location = new Point(x, y);


            NationManager manager = new NationManager(NationName.Text);

            if (Houseradiobtn.Checked)
            {
                manager.getNation(_location).GetHouse().draw(g,pen);
                Point hp = manager.getNation(_location).GetHousePoint();
                if (!hp.IsEmpty)
                {

                    Housepoints.Add(hp);

                }


            }
            else if (Treeradiobtn.Checked)
            {

                 
               manager.getNation(_location).GetTrees().draw(g,pen);
               Point tp= (manager.getNation(_location).GetTreePoint());


                if (!tp.IsEmpty)
                {

                    Treepoints.Add(tp);

                }
                

            }
            else if (WaterRadiobtn.Checked)
            {
                manager.getNation(_location).GetWaterSources().draw(g,pen);
                Point wp=(manager.getNation(_location).GetWaterPoint());

                if (!wp.IsEmpty)
                {

                    Waterpoints.Add(wp);
                }
            } 

            else
            {
                MessageBox.Show("Please Select What You Want To Draw");
            }


        }

        private void Openvillagebtn_Click(object sender, EventArgs e)
        {
            if (_nationame != "")
            {
                OpenVillageState opencommand = new OpenVillageState();
                NewVillagebtn_Click(sender, e);
                opencommand.Execute();
                _villagestate = opencommand.get_villageState();
                
                DrawPanel.Refresh();
                setState(_villagestate);
            }
            else
            {
                MessageBox.Show("Show Something");
            }
        }

        
        

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }
    }
}
