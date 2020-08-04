using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public partial class VillageEditorWindow : Form
    {

        private Panel drawingPanel;
        private Panel toolsPanel;

        public VillageEditorWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            toolsPanel = new Panel();
            SuspendLayout();
            InitDrawingPanel();
            //InitToolsPanel();
            //InitWindow();
            ResumeLayout(false);

        }

        private void InitDrawingPanel()
        {
            drawingPanel = new Panel
            {
                Location = new Point(0, 0),
                Name = "drawingPanel",
                Size = new Size(600, 400),
                TabIndex = 0,
                BackColor = Color.Indigo

            };
        }

    }
}
