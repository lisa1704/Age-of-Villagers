package Project.Utilities;

import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Bangladeshi_Farmers implements INations {
    private double WaterBodyWidth = 24;
    private double WaterBodyheight = 16;

    public Bangladeshi_Farmers(){
        super();
    }

    @Override
    public ArrayList<Shape> drawHouse(double x, double y) {
        ArrayList<Shape> House = new ArrayList<Shape>();
        double halfWidth = houseWidth/2;
        double halfHeight = houseHeight/2;
        Line l1 = new Line(x-halfWidth,y,x+halfWidth,y);
        House.add(l1);
        Line l2 = new Line(x-halfWidth,y+halfHeight,x+halfWidth,y+halfHeight);
        House.add(l2);
        Line l3 = new Line(x-halfWidth,y,x-halfWidth,y+halfHeight);
        House.add(l3);
        Line l4 = new Line(x+halfWidth,y,x+halfWidth,y+halfHeight);
        House.add(l4);
        Line l5 = new Line(x-halfWidth,y,x,y-halfHeight);
        House.add(l5);
        Line l6 = new Line(x+halfWidth,y,x,y-halfHeight);
        House.add(l6);
        return House;
    }

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
        arc.setLength(1000.0);

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

    @Override
    public void drawWaterBody(double x, double y) {

    }
}
