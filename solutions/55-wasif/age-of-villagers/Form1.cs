using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace age_of_villagers
{
    public partial class Form1 : Form
    {
        public string village_name;
        public string village_type;
        public string item;
        Village newvillage;
        village_factory villfact;
        Graphics gp;
        Point p;
        public Form1()
        {
            InitializeComponent();
            newvillage = new Village();
            villfact = new village_factory(gp, p);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            village_name = textBox2.Text;
            newvillage.setName(village_name);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            village_type = comboBox1.Text;
            panel1.BackColor = villfact.get_nation(village_type).draw_terrain();
            Debug.WriteLine(village_type);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            item = "house";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            item = "tree";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            item = "water";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics gp = panel1.CreateGraphics();
            village_factory new_village = new village_factory(gp, e.Location);
            if (item == "house")
            {
                new_village.get_nation(village_type).draw_house();
                newvillage.housepoint.Add(e.Location);
            }
            else if (item == "tree")
            {
                new_village.get_nation(village_type).draw_tree();
                newvillage.treepoint.Add(e.Location);
            }
                
            else if (item == "water")
            {
                new_village.get_nation(village_type).draw_watersource();
                newvillage.waterpoint.Add(e.Location);

            }
        }

        private void SaveVillageButtonClick(object sender, EventArgs e)
        {
            Save_village sv = new Save_village();

            sv.save(newvillage);
        }
        private void NewVillageButtonClick(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
        private void OpenVillageButtonClick(object sender, EventArgs e)
        {

        }
    }
}


