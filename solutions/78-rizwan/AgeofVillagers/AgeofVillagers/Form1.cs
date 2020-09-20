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
        bool drawing = true;
        int x, y, h, w;
        Pen p = new Pen(Color.Red, 3);
        public Form1()
        {
            InitializeComponent();
        }

        private void newvillage_Click(object sender, EventArgs e)
        {
            //Form1.Refresh();
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
            //start = e.Location;
            Graphics g = this.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                x = e.X;
                y = e.Y;

                h = y+5;
                w = x+5;
                if (radioButton1.Checked == true)
                {
                    //RadioButton rb = radioButton1;
                    //Graphics g = this.CreateGraphics();
                    BangladeshiFarmers bf = new BangladeshiFarmers(g);
                    
                    bf.createTree(e);
                    //Rectangle shape = new Rectangle(x, y, h, w);
                    //g.DrawRectangle(p, shape);
                    //refactor
                }
                else if (radioButton2.Checked == true)
                {
                    //RadioButton rb = radioButton2;
                    //Graphics g = this.CreateGraphics();
                    BangladeshiFarmers bf = new BangladeshiFarmers(g);
                    bf.createHouse(e);
                }
                else if (radioButton3.Checked == true)
                {
                    //RadioButton rb = radioButton3;
                    //Graphics g = this.CreateGraphics();
                    BangladeshiFarmers bf = new BangladeshiFarmers(g);
                    bf.createWaterSource(e);
                }
            }
        }
        
        
    }
}
