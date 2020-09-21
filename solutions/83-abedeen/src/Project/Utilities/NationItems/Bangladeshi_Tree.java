package Project.Utilities.NationItems;

import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Bangladeshi_Tree implements ITree{
    public Bangladeshi_Tree(){ super();}
    @Override
    public ArrayList<Shape> drawTree(double x, double y) {
        ArrayList<Shape> tree = new ArrayList<Shape>();
        Arc arc = new Arc();
        arc.setCenterX(x);
        arc.setCenterY(y);
        arc.setRadiusX(TreeWidth/2);
        arc.setRadiusY((TreeWidth/2)+2);
        arc.setType(ArcType.OPEN);
        arc.setStroke(Color.BLACK);
        arc.setStrokeWidth(1);
        arc.setFill(Color.TRANSPARENT);
        arc.setStartAngle(0.0);
        arc.setLength(360.0);

        tree.add(arc);

        Line l1 = new Line(x-1,y,x+1,y);
        tree.add(l1);
        Line l2 = new Line(x-1,y+15,x+1,y+15);
        tree.add(l2);
        Line l3 = new Line(x-1,y,x-1,y+15);
        tree.add(l3);
        Line l4 = new Line(x+1,y,x+1,y+15);
        tree.add(l4);
        return tree;
    }
}
