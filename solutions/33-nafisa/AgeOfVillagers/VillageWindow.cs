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
        private Panel drawingPanel;
        private Panel toolsPanel;

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
            
            Addlabel("");

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
