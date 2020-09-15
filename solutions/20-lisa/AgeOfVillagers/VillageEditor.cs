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
    public partial class VillageEditor : Form
    {
        int x;
        int y;
        public VillageEditor()
        {
            InitializeComponent();
        }
    
        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = drawingPanel.CreateGraphics();
            Pen pen = new Pen(Color.Black);

        }

        private void VillageEditor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VillageEditor_Load_1(object sender, EventArgs e)
        {

        }

        private void VillageName_TextChanged(object sender, EventArgs e)
        {
            VillageName.Text = VillageName.Text;
        }

        private void mouseClick1_drawingPanel(object sender, MouseEventArgs e)
        {
            Point point = new Point(e.X, e.Y);
            x = point.X;
            y = point.Y;
            drawingPanel.Invalidate();

        }

        private void mouseClick_NationList(object sender, MouseEventArgs e)
        {

        }

        private void TreeClick(object sender, EventArgs e)
        {

        }

        private void WaterSourceClick(object sender, EventArgs e)
        {

        }

        private void HouseClick(object sender, EventArgs e)
        {

        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {

        }

        private void NewVillage_Click(object sender, EventArgs e)
        {

        }

        private void OpenVillage_Click(object sender, EventArgs e)
        {

        }
        private void NationBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectNation = NationBox.Items[NationBox.Items].ToString();
            MessageBox.Show(selectNation);
        }
    }
}
