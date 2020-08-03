using System.Drawing;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class VillageWindow : Form
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
            InitWindow();
            ResumeLayout(false);
        }

        private void InitWindow()
        {
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Controls.Add(toolsPanel);
            Controls.Add(drawingPanel);
            Name = "VillageWindow";
            Text = "Age of Villagers";

        }

        private void InitToolsPanel()
        {
            toolsPanel = new TableLayoutPanel
            {
                Location = new Point(600, 0),
                Name = "toolsPanel",
                Size = new Size(200, 400),
                TabIndex = 1,
                ColumnCount = 1,
                Padding = new Padding(30)
            };
            AddLabel("Age Of Villagers");
            AddLabel(" ");
            AddRadioButton("Tree");
            AddRadioButton("House");
            AddRadioButton("Water Source");
        }

        private void AddLabel(string text)
        {
            var label = new Label
            {

                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = int.MaxValue

            };
            toolsPanel.Controls.Add(label);
        }

        private void AddRadioButton(string text)
        {
            var button = new RadioButton
            {
                Text = text
            };
            toolsPanel.Controls.Add(button);
        }

        private void InitDrawingPanel()
        {
            drawingPanel = new Panel
            {
                Location = new Point(0, 0),
                Name = "drawingPanel",
                Size = new Size(600, 400),
                TabIndex = 0,
                BackColor = Color.AliceBlue

            };
        }
    }
}