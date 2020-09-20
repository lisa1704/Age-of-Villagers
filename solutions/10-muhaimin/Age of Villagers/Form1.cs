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
        IPainter nation;
        public Form1()
        {
            InitializeComponent();
            nation = new BangladeshiPainter(panel1);
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
            myVillage = myVS.restoreState();
            Refresh();
            myVillage.repaint(nation);
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
            Refresh();
            myVillage.RefreshVillage();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                myVillage.addHouse(new Axis(e.X, e.Y),nation);
            }
            else if (radioButton1.Checked == true)
            {
                myVillage.addTree(new Axis(e.X, e.Y), nation);
            }
            else if (radioButton3.Checked == true)
            {
                myVillage.addWSource(new Axis(e.X, e.Y), nation);
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
                nation = new ArabPainter(panel1);
            }
            else if (Nation.Text == "Bangladeshi Farmers")
            {
                nation = new BangladeshiPainter(panel1);
            }
            else if (Nation.Text == "Egyptian Kings")
            {
                nation = new EgyptianPainter(panel1);
            }
            else if (Nation.Text == "Inuit Hunters")
            {
                nation = new InuitPainter(panel1);
            }
            Refresh();
            myVillage.repaint(nation);
        }
        public void RefreshVillage()
        {
            houses.Clear();
            trees.Clear();
            wSources.Clear();
        }

    }
}
