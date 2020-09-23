using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class NationSelectorAfterOpenVill : Form
    {
        public string selected_nation = "";
        public NationSelectorAfterOpenVill()
        {
            InitializeComponent();
        }

        private void NationSelectorAfterOpen_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_nation = NationSelectorAfterOpen.Text;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.OK;
        }
    }
}
