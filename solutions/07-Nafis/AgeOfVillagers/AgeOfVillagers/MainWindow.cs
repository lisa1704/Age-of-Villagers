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
    public partial class MainWindow : Form
    {

        int x;
        int y;
        string text;
        string nation;
        Color background;
        Graphics g;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        

        private void drawingAreaPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            x = e.X;
            y = e.Y;

            g = drawingAreaPanel.CreateGraphics();

            if(text == "TREE")
            {
                g.DrawRectangle(pen, x, y, 50, 50);
            }
            else if(text == "HOUSE")
            {
                g.DrawEllipse(pen, x, y, 50, 50);
            }
            else
            {
                g.DrawRectangle(pen, x, y, 100, 100);
            }

           
        }

        private void TreeButton_MouseClick(object sender, MouseEventArgs e)
        {
            text = "TREE";
        }

        private void houseButton_MouseClick(object sender, MouseEventArgs e)
        {
            text = "HOUSE";
        }

        private void waterButton_MouseClick(object sender, MouseEventArgs e)
        {
            text = "WATER";
        }

        private void nationTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = nationTypeCombo.Text;

        }

        /*public void setBackground(string color)
        {
            if(color == "green" || color == "Green" || color == "GREEN")
            {
                background = Color.Green;
            }
        }*/
    }
}
