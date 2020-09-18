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
    public partial class Form1 : Form
    {
        int x;
        int y;
        Graphics g;
        String text = "";
        Village myVillage = new Village();
        VillageSerializer myVS = new VillageSerializer();
        OpenFileDialog ofd = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            myVS.saveState(myVillage);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ofd.Filter = "aov|*.aov";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                myVillage = myVS.openState(fileName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myVillage.setName(comboBox1.Text);
        }

        private void Nation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            Pen p = new Pen(Color.Black);
            Font fy = new Font("Helvetica", 10, FontStyle.Bold);
            Brush br = new SolidBrush(System.Drawing.Color.Black);
            g.DrawString(text, fy, br, new Point(x, y));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                painter.drawHouse(e.X, e.Y);
                myVillage.addHouse(new House(e.X, e.Y));
            }
            else if (radioButton1.Checked == true)
            {
                painter.drawTree(e.X, e.Y);
                myVillage.addTree(new Tree(e.X, e.Y));
            }
            else if (radioButton3.Checked == true)
            {
                painter.drawWaterSource(e.X, e.Y);
                myVillage.addWSource(new WaterSource(e.X, e.Y));
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            text = "Tree";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            text = "House";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            text = "Water";
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        AbstractPainter painter;

        private void Nation_TextChanged(object sender, EventArgs e)
        {
            if (Nation.Text == "Arab Bedouin")
            {
                painter = new ArabPainter(panel1);
            }
            else if (Nation.Text == "Bangladeshi Farmers")
            {
                painter = new BangladeshiPainter(panel1);
            }
            else if (Nation.Text == "Egyptian Kings")
            {
                painter = new EgyptianPainter(panel1);
            }
            else if (Nation.Text == "Inuit Hunters")
            {
                painter = new InuitPainter(panel1);
            }
        }
    }
}
