using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class Form1 : Form
    {
        public static String VillageName;
        public static String NationName;
        DrawingWindow window = new DrawingWindow();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VillageName = textBox1.Text;
            window.Show();
        }

        private void SelectNation_SelectedIndexChanged(object sender, EventArgs e)
        {
            NationName = SelectNation.Text;
           
        }
    }
}
