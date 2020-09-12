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
    public partial class VillageWindow : Form
    {
        int x;
        int y;
        Graphics g;
        string text = null;
        public VillageWindow()
        {
            InitializeComponent();
        }

        private void drawing_space_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {
            g = drawing_space.CreateGraphics();
        }

        private void Village_name_textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            text = objTextBox.Text;
        }

        private void NationlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void new_village_btn_Click(object sender, EventArgs e)
        {

        }

        private void save_village_btn_Click(object sender, EventArgs e)
        {

        }

        private void open_village_btn_Click(object sender, EventArgs e)
        {

        }

        private void House_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tree_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void water_btn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
