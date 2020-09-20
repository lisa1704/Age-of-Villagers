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
    public partial class editorVillagers : Form
    {
        string villageName;
        string nation;

        public editorVillagers()
        {
            InitializeComponent();
        }



        private void villageNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void setVillageName(string name)
        {
            villageNameBox.Text = name;
            villageName = name;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nation = comboBox1.Text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void house_rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tree_rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void water_rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void New_Click(object sender, EventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
