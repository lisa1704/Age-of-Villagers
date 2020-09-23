using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Age_of_Villagers
{
    public class VillageConditionEdit
    {
        private readonly NationController nationController;
        private readonly Graphics graphics;
        private readonly Pen pen;
        private readonly Panel panel;
       
        public VillageConditionEdit(Graphics graphics, Pen pen, Panel panel, NationController nationController)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.panel = panel;
            this.nationController = nationController;
        }

        public void ResetState(VillageCondition villageCondition, string check)
        {

            foreach (Point point in villageCondition.HousePoint)
            {
                nationController.GetNation(point).HouseDraw().draw(graphics, pen);
            }
            foreach (Point point in villageCondition.TreePoint)
            {
                nationController.GetNation(point).TreeDraw().draw(graphics, pen);
            }
            foreach (Point point in villageCondition.WaterResourcePoint)
            {
                nationController.GetNation(point).WaterSourceDraw().draw(graphics, pen);
            }

        }

    }
}
