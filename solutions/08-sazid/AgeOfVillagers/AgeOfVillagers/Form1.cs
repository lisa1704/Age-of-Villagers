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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void houseButton_Click(object sender, EventArgs e)
        {

        }

        private void treeButton_Click(object sender, EventArgs e)
        {

        }

        private void submitName_Click(object sender, EventArgs e)
        {
            villageName.Text = villageNameInput.Text;
            villageNameInput.Text = "Enter Village Name";
            villageNameInput.ForeColor = Color.Silver;
        }

        private void villageNameInput_Enter(object sender, EventArgs e)
        {
            if (villageNameInput.Text == "Enter Village Name")
            {
                villageNameInput.Text = "";

                villageNameInput.ForeColor = Color.Black;
            }
        }

        private void villageNameInput_Leave(object sender, EventArgs e)
        {
            if (villageNameInput.Text == "")
            {
                villageNameInput.Text = "Enter Village Name";

                villageNameInput.ForeColor = Color.Silver;
            }
        }

        private void nationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(nationList.Text);
            drawinPanel.BackColor = Color.Blue;
        }
    }
}
