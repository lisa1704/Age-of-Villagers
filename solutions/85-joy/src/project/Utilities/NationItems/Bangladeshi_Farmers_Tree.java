package project.Utilities.NationItems;

import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Bangladeshi_Farmers_Tree implements  ITree{
    @Override
    public ArrayList<Shape> drawAsset(double x1, double y1) {
        ArrayList<Shape> Tree = new ArrayList<Shape>();

        //Top Circle
        Arc arc = new Arc();
        arc.setCenterX(x1);
        arc.setCenterY(y1);
        arc.setRadiusX(TreeWidth/2.0);
        arc.setRadiusY((TreeHeight/2.0)-3);
        arc.setStartAngle(0.0);
        arc.setLength(100000.0);
        arc.setType(ArcType.OPEN);
        arc.setStroke(Color.BLACK);
        arc.setFill(Color.TRANSPARENT);

        Tree.add(arc);
        //The Rectangle

        Line line1 = new Line(x1-1,y1,x1+1,y1);
        Tree.add(line1);
        Line line2 = new Line(x1-1,y1,x1-1,y1+15);
        Tree.add(line2);
        Line line3 = new Line(x1-1,y1+15,x1+1,y1+15);
        Tree.add(line3);
        Line line4 = new Line(x1+1,y1+15,x1+1,y1);
        Tree.add(line4);

        return Tree;
    }
}
