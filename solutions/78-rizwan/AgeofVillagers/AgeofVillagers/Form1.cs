using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
namespace AgeofVillagers
{
    public partial class Form1 : Form
    {
        int x, y, h, w;
        Pen p = new Pen(Color.Red, 3);
        public Form1()
        {
            InitializeComponent();
        }

        private void newvillage_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void savevillage(object sender, EventArgs e)
        {
            
        }

        private void panelDrawingBoard_MouseUp(object sender, MouseEventArgs e)
        {
            //drawing = false;
            
        }
        private void panelDrawingBoard_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void panelDrawingBoard_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            var nat = (dynamic)null;
            string nation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            
            x = e.X;
            y = e.Y;

            h = y+5;
            w = x+5;
            NationFactory nf = new NationFactory(nation,g);

            nat = nf.createNation();
            nat.terrain(panel1);
            if (radioButton1.Checked == true)
            {
                nat.createTree(e);
            }
            else if (radioButton2.Checked == true)
            {
                nat.createHouse(e);
            }
            else if (radioButton3.Checked == true)
            {
                nat.createWaterSource(e);
            }
            
        }
        
        
    }
}
