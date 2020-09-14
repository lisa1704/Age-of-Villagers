using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class Village
    {
        //AgeOfVillagersForm ageOfVillagersForm = new AgeOfVillagersForm();
        public string nation;
        public string village;
        public List<Point> treePoints;
        public List<Point> housePoints;
        public List<Point> riverPoints;
        public Village(string nation, string village, List<Point> tree, List<Point> house, List<Point> river)
        {
            this.nation = nation;
            this.village = village;
            this.treePoints = tree;
            this.housePoints = house;
            this.riverPoints = river;
        }
        //public Panel drawingSpace;
        /*public void setFields()
        {
            nation = ageOfVillagersForm.lblNationName.Text;
            village = ageOfVillagersForm.lblVillageName.Text;
            //drawingSpace = ageOfVillagersForm.pnlDrawingSpace;
            treePoints = ageOfVillagersForm.treePoints;
            housePoints= ageOfVillagersForm.housePoints;
            riverPoints = ageOfVillagersForm.riverPoints;
        }*/
    }
}
