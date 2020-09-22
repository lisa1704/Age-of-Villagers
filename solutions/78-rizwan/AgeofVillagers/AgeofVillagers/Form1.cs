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
            //start = e.Location;
            Graphics g = panel1.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;

                h = y+5;
                w = x+5;
                if (radioButton1.Checked == true)
                {
                    //RadioButton rb = radioButton1;
                    //Graphics g = this.CreateGraphics();
                    BangladeshiFarmers bf = new BangladeshiFarmers(g);
                    ArabBeduoin a = new ArabBeduoin(g);
                    EgyptianKing eg = new EgyptianKing(g);
                    eg.createTree(e);
                    //a.createTree(e);
                    //bf.createTree(e);
                    //Rectangle shape = new Rectangle(x, y, h, w);
                    //g.DrawRectangle(p, shape);
                    //refactor
                }
                else if (radioButton2.Checked == true)
                {
                    //RadioButton rb = radioButton2;
                    //Graphics g = this.CreateGraphics();
                    BangladeshiFarmers bf = new BangladeshiFarmers(g);
                    EgyptianKing eg = new EgyptianKing(g);
                    InuitHunters inu = new InuitHunters(g);
                    inu.createHouse(e);
                    //eg.createHouse(e);
                    //bf.createHouse(e);
                    ArabBeduoin a = new ArabBeduoin(g);
                    //a.createHouse(e);
                }
                else if (radioButton3.Checked == true)
                {
                    //RadioButton rb = radioButton3;
                    //Graphics g = this.CreateGraphics();
                    BangladeshiFarmers bf = new BangladeshiFarmers(g);
                    EgyptianKing eg = new EgyptianKing(g);
                    eg.createWaterSource(e);
                    //bf.createWaterSource(e);
                }
            }
        }
        
        
    }
}
