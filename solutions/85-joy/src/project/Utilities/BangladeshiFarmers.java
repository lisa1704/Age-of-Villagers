package project.Utilities;

import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class BangladeshiFarmers implements INation{
    private  String TerrainColor = "GREEN";

    public BangladeshiFarmers(){
        super();
    }
    @Override
    public ArrayList<Shape> DrawHouse(double x1, double y1) {
        ArrayList<Shape> House = new ArrayList<Shape>();
        //Upper Triangle..
        Line line1 = new Line(x1,y1,x1+HouseWidth,y1);
        House.add(line1);
        Line line2 = new Line(x1,y1,x1+(HouseWidth/2.0),y1-(HouseHeight/2.0));
        House.add(line2);
        Line line3 = new Line(x1+HouseWidth,y1,x1+(HouseHeight/2.0),y1-(HouseHeight/2.0));
        House.add(line3);
        //Lower Rectangle
        Line line4 = new Line(x1,y1,x1,y1+HouseHeight);
        House.add(line4);
        Line line5 = new Line(x1,y1+HouseHeight,x1+HouseWidth,y1+HouseHeight);
        House.add(line5);
        Line line6 = new Line(x1+HouseWidth,y1+HouseHeight,x1+HouseWidth,y1);
        House.add(line6);

        return House;
    }

    @Override
    public ArrayList<Shape> DrawTree(double x1,double y1) {
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

    @Override
    public void DrawWaterSource() {

    }

    @Override
    public String getTerrainColor() {
        return TerrainColor;
    }
}
