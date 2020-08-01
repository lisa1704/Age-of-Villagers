using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class VillageWindow : Form
    {
        int x;
        int y;
        Graphics g;
        string text = "";
        public VillageWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void villagePanel_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            g = villagePanel.CreateGraphics();
            Font fy = new Font("Helvetica", 10, FontStyle.Bold);
            Brush br = new SolidBrush(System.Drawing.Color.Red);
            g.DrawString(text, fy, br, new Point(x, y));
        }

        private void treeButton_Click(object sender, EventArgs e)
        {
            text = "Tree";
        }

        private void houseBotton_Click(object sender, EventArgs e)
        {
            text = "House";
        }

        private void watersourceButton_Click(object sender, EventArgs e)
        {
            text = "River";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(villageNameBox.Text);
        }

        private void nationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNation = nationList.Items[nationList.SelectedIndex].ToString();
            MessageBox.Show(selectedNation);
        }
    }
}
