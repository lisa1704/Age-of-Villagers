using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_of_villagers
{
    public partial class villageEditor : Form
    {
        int xCoordinate;
        int yCoordinate;
        Graphics g;
        Font font = new Font("Helvetica", 10, FontStyle.Bold);
        Brush brush = new SolidBrush(System.Drawing.Color.Green);
        string text = "";
        public villageEditor()
        {
            
            InitializeComponent();

        }


        private void villageEditor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            text = "house";
            brush = new SolidBrush(System.Drawing.Color.Black);
        }

        private void saveVillageButton_Click(object sender, EventArgs e)
        {

        }

        private void openVillageButton_Click(object sender, EventArgs e)
        {

        }

        private void newVillageButton_Click(object sender, EventArgs e)
        {
            VillageCanvas.Invalidate();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void villageNameTextBox_enter(object sender, EventArgs e)
        {
            if (villageNameTextBox.Text == "Enter Village Name")
            {
                villageNameTextBox.Text = "";
            }
        }

        private void villageNameTextBox_leave(object sender, EventArgs e)
        {
            if (villageNameTextBox.Text == "")
            {
                villageNameTextBox.Text = "Enter Village Name";
            }

        }

        private void nationNameTextBox_enter(object sender, EventArgs e)
        {
            if (nationNameTextBox.Text == "Enter Nation Name")
            {
                nationNameTextBox.Text = "";
            }

        }

        private void nationNameTextBox_leave(object sender, EventArgs e)
        {
            if (nationNameTextBox.Text == "")
            {
                nationNameTextBox.Text = "Enter Nation Name";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VillageCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            xCoordinate = e.X;
            yCoordinate = e.Y;
            g = VillageCanvas.CreateGraphics();
            g.DrawString(text, font, brush, new Point(xCoordinate, yCoordinate));
        }

        private void treeButtonClick(object sender, EventArgs e)
        {
            text = "tree";
            brush = new SolidBrush(System.Drawing.Color.Green);
        }

        private void WaterSourceClick(object sender, EventArgs e)
        {
            text = "water source";
            brush = new SolidBrush(System.Drawing.Color.Blue);
        }
    }
}
