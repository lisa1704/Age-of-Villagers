using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace age_of_villagers
{
    public partial class Gameform : Form
    {
        private string text = "";
        public Gameform()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TreeButton_Click(object sender, EventArgs e)
        {
            text = text + "added a new tree...";
        }

        private void HouseButton_Click(object sender, EventArgs e)
        {
            text = text + "added a new house...";
        }

        private void WaterButton_Click(object sender, EventArgs e)
        {
            text = text + "added a new water...";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            text = text + "saving village...";
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            text = text + "creating village...";
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            text = text + "opening village...";
        }

        private void VillageName_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(VillageName.Text);
        }

        private void NationName_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(NationName.Text);
        }
        public string get_VillageName()
        {
            return VillageName.Text;
        }

        public string get_NationName()
        {
            return NationName.Text;
        }
        public string get_Status()
        {
            return text;
        }

        private void panel2_paint(object sender, PaintEventArgs e)
        {
            Shape nation = NationFactory.GetNation("currentNation");
            IShape shape = nation.GetItem("currentselect");
            shape.draw(Cursor.Position.X, Cursor.Position.Y);
        }
    }
}
