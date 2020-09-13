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
    public class VillageWindow : Form
    {
        private Panel drawingPanel;
        private Panel toolsPanel;
        string item;
        //string villagename;
        //string nationname;

        public VillageWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            toolsPanel = new Panel();
            SuspendLayout();
            InitDrawingPanel();
            InitToolsPanel();
            InitVillageWindow();
            ResumeLayout(false);

        }
        private void InitDrawingPanel()
        {
            drawingPanel = new Panel
            {
                Location = new Point(0, 0),
                Name = "DrawingPanel",
                Size = new Size(600, 400),
                TabIndex = 0,
                BackColor =Color.White
            };
        }
        private void InitToolsPanel()
        {
            toolsPanel = new TableLayoutPanel
            {
                Location = new Point(600, 0),
                Name = "ToolsPanel",
                Size = new Size(200, 400),
                TabIndex = 1,
                ColumnCount = 1,
                Padding = new Padding(30)
            };

            Addlabel("Age Of Villagers");
            Addlabel("KataKhali");
            Addlabel("Bangladeshi Farmers");
            Addlabel("");
            AddRadioButton("Tree");
            AddRadioButton("House");
            AddRadioButton("WaterSource");
            Addlabel("");
            AddButton("Save Village");
            AddButton("New Village");
            AddButton("Open Village");

        }

        

        private void InitVillageWindow()
        {
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(drawingPanel);
            Controls.Add(toolsPanel);
            Name = "VillageWindow";
            Text = "Age of Villagers";
            //Load += new System.EventHandler(this.NewVillage_Load);

        }

       

        private void AddButton(string text)
        {
            var button = new Button
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = int.MaxValue
            };
            toolsPanel.Controls.Add(button);
            if (button.Text == "Save Village")
            {
                button.Click += new System.EventHandler(this.SaveVillage_Click);
            }
        }

        private void SaveVillage_Click(object sender, EventArgs e)
        {
            
            if (item == "Tree")
            {
                MessageBox.Show(item);
            }
            if (item == "House")
            {
                MessageBox.Show(item);
            }
            if (item == "WaterSource")
            {
                MessageBox.Show(item);
            }
        }

        private void AddRadioButton(string text)
        {
            var radiobutton = new RadioButton
            {
                Text = text
            };
            toolsPanel.Controls.Add(radiobutton);
            if (radiobutton.Text == "Tree")
            {
                radiobutton.CheckedChanged += new System.EventHandler(this.tree_CheckedChanged);
            }
            if (radiobutton.Text == "House")
            {
                radiobutton.CheckedChanged += new System.EventHandler(this.House_CheckedChanged);
            }
            if (radiobutton.Text == "WaterSource")
            {
                radiobutton.CheckedChanged += new System.EventHandler(this.WaterSource_CheckedChanged);
            }

        }

        private void WaterSource_CheckedChanged(object sender, EventArgs e)
        {
            item = "WaterSource";
        }

        private void House_CheckedChanged(object sender, EventArgs e)
        {
            item = "House";
        }

        private void tree_CheckedChanged(object sender, EventArgs e)
        {

            item = "Tree";

        }

        private void Addlabel(string text)
        {
            var label = new Label
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = int.MaxValue
            };
            toolsPanel.Controls.Add(label);

            
        }

       


    }
}
