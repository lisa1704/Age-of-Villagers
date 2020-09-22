using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void button3_Click(object sender, EventArgs e)
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
            string q = null;
            var nat = (dynamic)null;
            string nation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;

                h = y+5;
                w = x+5;
                if (nation == "Bangladeshi Farmers")
                    nat = new BangladeshiFarmers(g);
                else if (nation == "Arab Bedouin")
                    nat = new ArabBeduoin(g);
                else if (nation == "Egyptian King")
                    nat = new EgyptianKing(g);
                else if (nation == "Inuit Hunters")
                    nat = new InuitHunters(g);
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
}
