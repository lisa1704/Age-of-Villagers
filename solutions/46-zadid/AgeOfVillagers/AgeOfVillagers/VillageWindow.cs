using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    
    public partial class VillageWindow : Form
    {
        private string villname, villtype;

        private INation nation;

        public VillageWindow()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            NationType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void drawpanel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Draw_panel(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Villagename_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void NationtypeSelectedIndexChanged(object sender, EventArgs e)
        {
            villname = villagename.Text;
            villtype = NationType.SelectedItem.ToString();

            Debug.WriteLine(villname);
            Debug.WriteLine(villtype);

            NationCreator nationCreator = new NationCreator();

            nation = nationCreator.GetNation(villtype);
        }

        private void Side_panel(object sender, PaintEventArgs e)
        {

        }

        private void RefreshForm(object sender, EventArgs e)
        {
            foreach (var item in sidepanel.Controls)
                if(item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox t = item as TextBox;
                    t.Text = string.Empty;
                }
            NationType.ResetText();
            NationType.Text = "Village type";
            drawpanel.Invalidate();
        }
    }
}
