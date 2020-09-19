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
        public int x;
        public int y;
        public Graphics g;
        Boolean saved;
        string text = "";
        readonly INationFactory nationfactory=new Nationfactory();
        public INation nation=null;
        public ICommandVillage command;
        public VillageWindow()
        {
            InitializeComponent();
            g = villagePanel.CreateGraphics();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
        }

        public void villagePanel_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            Pen pen=  new Pen(Color.Black);
            if (text == "Tree")
            {
                IShape tree=nation.draw_tree(new Point(x, y));
                tree.draw(g, pen);
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

        public void treeButton_Click(object sender, EventArgs e)
        {
            text = "Tree";
        }

        public void houseBotton_Click(object sender, EventArgs e)
        {
            text = "House";
        }

        public void watersourceButton_Click(object sender, EventArgs e)
        {
            text = "River";
        }

        public void saveButton_Click(object sender, EventArgs e)
        {
            command = new SaveVillage();
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog()==DialogResult.OK)
            {
                command.execute(save.FileName, nation);
                saved = true;
            }
        }

        public void nationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedNation = nationList.Items[nationList.SelectedIndex].ToString();
            nation_create(selectedNation);
            village_name(villageNameBox.Text);
            nation.set_graphics(g);
            villagePanel.BackColor = nation.set_background();
        }

       public void nation_create(string selectedNation)
        {
            nation = nationfactory.GetNation(selectedNation);
        }

        public void village_name(string name) {
            if(nation!=null)
                nation.set_villagename(name);
        }

        public void openButton_Click(object sender, EventArgs e)
        {
            
            villagePanel.Invalidate();
            command = new OpenVillage();
            OpenFileDialog open = new OpenFileDialog();
            if (nation == null)
            {
                MessageBox.Show("Nation Have to be choosen first");
                
            }
            else if (open.ShowDialog() == DialogResult.OK & nation != null)
            {
                if (System.IO.Path.GetExtension(open.FileName).Equals(".aov"))
                {
                    command.execute(open.FileName, nation);
                    villageNameBox.Text = nation.get_villagename();
                }
                else
                    MessageBox.Show("Unsupported File type");
            }
        }

        public void newButton_Click(object sender, EventArgs e)
        {
            if(nation!=null && saved==false)
                this.saveButton_Click(sender, e);
            villagePanel.Invalidate();
            saved = false;
            villageNameBox.Clear();
        }

        private void villageNameBox_TextChanged(object sender, EventArgs e)
        {
            village_name(villageNameBox.Text);

        }
    }
}
