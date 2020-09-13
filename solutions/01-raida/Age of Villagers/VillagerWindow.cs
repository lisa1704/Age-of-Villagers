using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class VillageWindow : Form
    {
        int x;
        int y;
        Graphics g;
        string text = "";
        readonly INationFactory nationfactory=new Nationfactory();
        INation nation;
        public VillageWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void villagePanel_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            //g = villagePanel.CreateGraphics();
            //nation.set_graphics(g);
            //Pen myPen = new Pen(Color.Black);
            //nation.set_pen(myPen);
            if (text == "Tree")
            {
                nation.draw_tree(new Point(x, y));
            }
            else if(text == "House")
            {
                nation.draw_house(new Point(x, y));
            }
            else if(text == "River")
            {
                nation.draw_river(new Point(x, y));
            }

        }

        private void treeButton_Click(object sender, EventArgs e)
        {
            text = "Tree";
        }

        private void houseBotton_Click(object sender, EventArgs e)
        {
            text = "House";
        }

        private void watersourceButton_Click(object sender, EventArgs e)
        {
            text = "River";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ISaveVillage village = new SaveVillage();
            MessageBox.Show(villageNameBox.Text);
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog()==DialogResult.OK)
            {
                village.save(save.FileName, nation);
            }
        }

        private void nationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNation = nationList.Items[nationList.SelectedIndex].ToString();
            nation=nationfactory.GetNation(selectedNation);
            nation.set_villagename(villageNameBox.Text);
            g = villagePanel.CreateGraphics();
            nation.set_graphics(g);
            Pen myPen = new Pen(Color.Black);
            nation.set_pen(myPen);
        }

        private void openButton_Click(object sender, EventArgs e)
        {

            IOpenVillage village = new OpenVillage();
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                village.open(open.FileName, nation);
            }
        }
    }
}
