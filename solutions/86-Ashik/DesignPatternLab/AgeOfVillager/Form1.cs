using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillager
{
    public partial class Form1 : Form
    {
        public Form1(MouseEventArgs m, bool radioChecked)
        {
            this.m = m;
            this.radioChecked = radioChecked;
        }
        private EventHandler combobox1_SelectedIndexChanged;
        private bool radioChecked = false;
        private MouseEventArgs m;

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.m = e;
            Graphics g = this.CreateGraphics();
            string myNation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            var nationManager = new NationManager(myNation, new NationFactory(g, this));

            //tree
            if (radioButton1.Checked)
            {
                nationManager.DrawTree(e);
                radioChecked = true;
            }
            //house
            if (radioButton2.Checked)
            {
                nationManager.DrawHouse(e);
                radioChecked = true;
            }
            //water source
            else if (radioButton3.Checked)
            {
                nationManager.DrawWaterSource(e);
                radioChecked = true;
            }

            SaveItem saveItem = new SaveItem(this, e);
            saveItem.Save();
        }

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += combobox1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Refresh();
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            string myNation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            var nationManager = new NationManager(myNation, new NationFactory(g, this));

            nationManager.SetColor();
            panel1.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Most latest object is saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            string myNation = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            var nationManager = new NationManager(myNation, new NationFactory(g, this));
            OpenItem open = new OpenItem(nationManager, m, radioChecked);
            open.Open();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
    }
}
