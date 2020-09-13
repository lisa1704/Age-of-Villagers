using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Age_of_villagers
{
    public partial class Form1 : Form
    {
        string type;
        string item;
        Nationfactory nationfactory = new Nationfactory();
        village village;
        public string name;

        public List<Point> W_points { get; set; } = new List<Point>();
        public List<Point> T_points { get; set; } = new List<Point>();
        public List<Point> H_points { get; set; } = new List<Point>();

        public void get_state()
        {
            village.name = villagename.Text;
            village.house_point = this.H_points;
            village.tree_point = this.T_points;
            village.waterresource_point = this.W_points;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void side_panel(object sender, PaintEventArgs e) { }
        private void house_Click(object sender, EventArgs e)
        {
            item = "house";
        }

        private void tree_Click(object sender, EventArgs e)
        {
            item = "tree";
        }

        private void watersource_Click(object sender, EventArgs e)
        {
            item = "water";
        }

        private void draw_panel(object sender, PaintEventArgs e)
        {
            Graphics g = drawpanel.CreateGraphics();
                foreach (Point pt in H_points)
                {
                nationfactory.GetNation(type).Draw_house(g, pt);
                }
                foreach (Point pt in T_points)
                {
                nationfactory.GetNation(type).Draw_tree(g, pt);
                }
                foreach (Point pt in W_points)
                {
                nationfactory.GetNation(type).Draw_watersource(g, pt);
            }
        }

        private void drawpanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (item == "house")
            {
                H_points.Add(e.Location);
            }
            if (item == "tree")
            {
                T_points.Add(e.Location);
            }
            if (item == "water")
            {
                W_points.Add(e.Location);
            }
            drawpanel.Invalidate();
        }

        private void villagename_KeyDown(object sender, KeyEventArgs e)
        {
            name=villagename.Text;
        }

        private void vallagetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = villagetype.Text;
            nationfactory.GetNation(type);
            drawpanel.Refresh();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Icommand command = new Savevillage();
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"E:\Dp_Assignment_Age_of_villagers\save\";
            sfd.RestoreDirectory = true;
            sfd.FileName = "*.txt";
            sfd.DefaultExt = "txt";
            sfd.Filter = "AoV file(*.txt)| *.txt";
            get_state();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = sfd.OpenFile();
                command.execute(fileStream,village);
                fileStream.Close();
            }
        }

        private void open_Click(object sender, EventArgs e)
        {

        }

        private void newvillage_Click(object sender, EventArgs e)
        {
            H_points.Clear();
            T_points.Clear();
            W_points.Clear();
            drawpanel.Refresh();
            
        }
    }
}
/*Stream fileStream = sfd.OpenFile();
StreamWriter sw = new StreamWriter(fileStream);

sw.WriteLine("village name: ");
                sw.WriteLine(villagename.Text);
                sw.WriteLine("village Type: ");
                sw.WriteLine(villagetype.Text);
                sw.WriteLine("h_points: ");
                foreach (Point pt in h_points)
                {
                    sw.WriteLine(pt);
                }
                sw.WriteLine("t_points: ");
                foreach(Point pt in t_points)
                {
                    sw.WriteLine(pt);
                }
                sw.WriteLine("w_points: ");
                foreach(Point pt in w_points)
                {
                    sw.WriteLine(pt);
                }
                sw.Close();
                fileStream.Close();*/
