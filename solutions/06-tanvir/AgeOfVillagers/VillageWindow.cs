using System.Drawing;
using System.windows.Forms;
namespace AgeOfVillagers

{
    public cass VillageWindow : Form
        {
         
            private Panel drawingPanel;
            private Panel toolsPanel;
            
            public Villagewindow()
            {
            
                IntializeComponent();
            
            }
            
            private void InIntializeComponent()
            
            {
                
                toolsPanel = new Panel();
                SuspendLayout();
                InitDrawingPanel();
                InitToolsPanel();
                Initwindow();
                ResumeLayout(false);
                
            }
            
            private void InitDrawingPanel()
            {
            
                drawingPanel = new Panel;
                {
                    Location = new Point(0,0),
                    Name = "drawingPanel",
                    Size = new size(600,400),
                    TabIndex = 0,
                    BackColor = Color.White
             
                };
            }
            
            private void InitToolsPanel()
            {
            
                 toolsPanel = new TableLayoutPanel;
                 {
                        Location = new Point(600,0),
                        Name = "toolsPanel",
                        Size = new size(200,400),
                        TabIndex = 1,
                        columnCount = 1,
                        Padding = new Padding(30)

                 };
                 
                 AddLabel("Age of Villagers");
                 AddLabel("Village Name");
                 AddLabel("Nation Name");
                 AddLabel("");
                 AddRadioButton("Tree");
                 AddRadioButton("House");
                 AddRadioButton("Water Source");
                 AddLabel("");
                 AddButton("Save Village");
                 AddButton("New Village");
                 AddButton("Open Village");
                 
             
            }
            
            private void AddButton(string text)
            {
            
                var button = new Button
                {
                
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = int.MaxValue
                
                };
                toolsPanel.Control.Add(button);
            
            }
            
             private void AddLabel(string text)
            {
            
                var label = new Label
                {
                
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = int.MaxValue
                
                };
                toolsPanel.Control.Add(label);
            
            }
            
             private void AddRadioButton(string text)
            {
            
                var radiobutton = new RadioButton {Text = text};
                toolsPanel.Control.Add(radiobutton);
            
            }
            
            private void Initwindow()
            
            {
                AutoScaleDimension = new SizeFI(7F, 15F);
                AutoScaleMode = AutoScaleMode.Font;
                ClientSize = new Size(800,400);
                Controls.Add(toolsPanel);
                Controls.Add(drawingPanel);
                Name = "VillageWindow";
                Text = "Age Of Villagers"
            
            }

        
        }
       
}