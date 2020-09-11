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
        readonly Graphics graphic;
        private string villname, villtype;

        private INation nation;

        public VillageWindow()
        {
            InitializeComponent();
            graphic = drawpanel.CreateGraphics();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            NationType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Drawpanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point location = new Point(e.Location.X, e.Location.Y);

            if(house.Checked)
            {
                nation.DrawHouse(graphic, location);
            }
            else if(tree.Checked)
            {
                nation.DrawTree(graphic, location);
            }
            else if(watersource.Checked)
            {
                nation.DrawWaterResource(graphic, location);
            }
        }

        
        private void NationtypeSelectedIndexChanged(object sender, EventArgs e)
        {
            villname = villagename.Text;
            villtype = NationType.SelectedItem.ToString();

            Debug.WriteLine(villname);
            Debug.WriteLine(villtype);

            NationCreator nationCreator = new NationCreator();

            nation = nationCreator.GetNation(villtype);
            nation.BackgoundColor(graphic);
        }

        private void RefreshForm(object sender, EventArgs e)
        {
            foreach (var item in sidepanel.Controls)
                if(item.GetType().Equals(typeof(TextBox)))
                {
                    TextBox t = item as TextBox;
                    t.Text = string.Empty;
                }
            foreach(var item in sidepanel.Controls)
                if(item.GetType().Equals(typeof(RadioButton)))
                {
                    RadioButton rb = item as RadioButton;
                    rb.Checked = false;
                }
            NationType.ResetText();
            NationType.Text = "Village type";
            drawpanel.Invalidate();
        }
    }
}
