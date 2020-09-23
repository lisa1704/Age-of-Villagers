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
    public partial class VillageWindow : Form
    {
        private NationController nationController;
        private string VillageName;
        private string NationName;
        Graphics graphics;
        Pen pen;
        int x = -1;
        int y = -1;
        bool move = false;
        private List<Point> HousePoints { get; set; } = new List<Point>();
        private List<Point> TreePoints { get; set; } = new List<Point>();
        private List<Point> WaterResourcePoints { get; set; } = new List<Point>();

        VillageCondition villageCondition;


        public VillageWindow()
        {
            InitializeComponent();
            graphics = VillageDrawing.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 2);
        }

        private void VillageWindow_Load(object sender, EventArgs e)
        {

        }

        private void VillageDrawing_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GameLabel_Click(object sender, EventArgs e)
        {

        }
        private void VillageNameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void HouseRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TreeRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WaterSourceRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SaveVillageButton_Click(object sender, EventArgs e)
        {
            GetCondition();
            VillageConditionSave village = new VillageConditionSave(villageCondition);
            village.PerformOperation();
        }

        private void NewVillageButton_Click(object sender, EventArgs e)
        {
            Form ConfirmName = new ConfirmName(this,VillageDrawing);
            ConfirmName.Show();
            VillageDrawing.Invalidate();
            HousePoints.Clear();
            TreePoints.Clear();
            WaterResourcePoints.Clear();
        }

        private void OpenVillageButton_Click(object sender, EventArgs e)
        {
            VillageConditionOpen villageConditionOpen = new VillageConditionOpen();
            villageConditionOpen.PerformOperation();

            villageCondition = villageConditionOpen.GetVillageCondition();

            HousePoints = villageCondition.HousePoint;
            TreePoints = villageCondition.TreePoint;
            WaterResourcePoints = villageCondition.WaterResourcePoint;

            Form selectVillage = new SelectVillage(this, graphics, pen, VillageDrawing, villageCondition);
            selectVillage.Show();
        }

        private void NationNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        public void GetCondition()
        {
            villageCondition = new VillageCondition(VillageNameText.Text, HousePoints, TreePoints, WaterResourcePoints);
        }

        private void VillageDrawing_MouseDown(object sender, EventArgs e)
        {
            x = e.X;
            y = e.Y;

            Point point = new Point(x, y);

            NationController nationController = new NationController(NationNameCombo.Text);

            if (HouseRB.Checked)
            {
                nationController.GetNation(point).HouseDraw().draw(graphics, pen);
                Point HousePoint = nationController.GetNation(point).GetHousePoint();
                if (!HousePoint.IsEmpty)
                {
                    HousePoints.Add(HousePoint);
                }
            }
            else if (TreeRB.Checked)
            {
                nationController.GetNation(point).TreeDraw().draw(graphics, pen);
                Point TreePoint = nationController.GetNation(point).GetTreePoint();
                if (!TreePoint.IsEmpty)
                {
                    TreePoints.Add(TreePoint);
                }
            }
            else if (WaterSourceRB.Checked)
            {
                nationController.GetNation(point).WaterSourceDraw().draw(graphics, pen);
                Point WaterResourcePoint = nationController.GetNation(point).GetWaterSourcePoint();
                if (!WaterResourcePoint.IsEmpty)
                {
                    TreePoints.Add(WaterResourcePoint);
                }
            }
            else
            {
                MessageBox.Show("Please Select an item!");
            }

        }
        private void VillageDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            x = -1;
            y = -1;
        }
    }
}
