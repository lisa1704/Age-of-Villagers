using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class EgyptianKing : INation
    {
        public EgyptianKing()
        {

        }
        public void DrawHouse(Point p, Panel drawingBoard)
        {
            EgyptianKingHouse egKingHouse = new EgyptianKingHouse(drawingBoard);
            egKingHouse.draw(p, drawingBoard);
        }

        public void DrawTree(Point p, Panel drawingBoard)
        {
            EgyptianKingTree egKingTree = new EgyptianKingTree(drawingBoard);
            egKingTree.draw(p, drawingBoard);
        }

        public void DrawWaterSource(Point p, Panel drawingBoard)
        {
            EgyptianKingWater egKingWater = new EgyptianKingWater(drawingBoard);
            egKingWater.draw(p, drawingBoard);
        }

        public void PaintTerrain(Point p, Panel drawingBoard)
        {
            drawingBoard.BackColor = System.Drawing.Color.Yellow;
        }
    }
}
