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
    public partial class AgeOfVillagersForm : Form
    {
        public AgeOfVillagersForm()
        {
            InitializeComponent();
        }

        private void pnlDrawingSpace_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlDrawingSpace_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Graphics graphics = pnlDrawingSpace.CreateGraphics();
            Brush green = new SolidBrush(Color.Green);
            Pen greenpen = new Pen(green, 10);
            graphics.DrawLine(greenpen, x, y, 100, 100);
        }

        public void setVillageName(string name)
        {
            this.lblVillageName.Text = name;
        }

        public void setNationName(string name)
        {
            this.lblNationName.Text = name;
        }

        private void btnNewVillage_Click(object sender, EventArgs e)
        {
            NewVillageCreateForm newVillageCreateForm = new NewVillageCreateForm();
            newVillageCreateForm.Show();
            this.Hide();
        }
    }
}
