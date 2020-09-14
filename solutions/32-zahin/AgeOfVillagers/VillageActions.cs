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
    public partial class VillageActions : Form
    {
        string item;
        string villageName;
        string villageType;

        public VillageActions()
        {
            InitializeComponent();
        }

        private void VillageActions_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void House_Click(object sender, EventArgs e)
        {
            item = "house";
        }

        private void tree_Click(object sender, EventArgs e)
        {
            item = "tree";
        }

        private void Water_Click(object sender, EventArgs e)
        {
            item = "water";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveVillage saveVillage = new SaveVillage();
            saveVillage.execute();
        }

        private void OpenVIllage_Click(object sender, EventArgs e)
        {
            OpenVillage openVillage = new OpenVillage();
            openVillage.execute();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Red);
            Point pt = e.Location;
            Point pt2 = new Point(100, 100);
            g.DrawLine(p, pt, pt2);
        }

        private void NewVillage_Click(object sender, EventArgs e)
        {
            panel1.Refresh();

        }
    }
}
