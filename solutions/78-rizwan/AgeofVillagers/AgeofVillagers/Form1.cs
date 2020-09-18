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
        bool drawing = false;
        RadioButton rb = null;
        Point start = new Point(0, 0);
        Point end = new Point(0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void newvillage_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelDrawingBoard_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }
        private void panelDrawingBoard_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void panelDrawingBoard_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
            }
        }
        private void radiobutton_click(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                rb = radioButton1;
            }
            else if (radioButton2.Checked == true)
            {
                rb = radioButton2;
            }
            else if (radioButton3.Checked == true)
            {
                rb = radioButton3;
            }
        }
        
    }
}
