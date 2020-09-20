package project.Utilities;

import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class EgyptianKings implements INation{
    private  String TerrainColor = "#F9D423";
    private double WaterSourceWidth = 12.0;
    private double WaterSourceHeight = 12.0;

    public EgyptianKings(){
        super();
    }


    @Override
    public ArrayList<Shape> DrawHouse(double x1, double y1) {
        ArrayList<Shape> House = new ArrayList<Shape>();

        Line line1 = new Line(x1,y1,x1+12,y1+3);
        line1.setStrokeWidth(2);
        House.add(line1);

        Line line2 = new Line(x1+12,y1+3,x1+HouseWidth,y1-5);
        line2.setStrokeWidth(2);
        House.add(line2);

        Line line3 = new Line(x1+HouseWidth,y1-5,x1+8,y1-13);
        line3.setStrokeWidth(2);
        House.add(line3);

        Line line4 = new Line(x1+8,y1-13,x1,y1);
        line4.setStrokeWidth(2);
        House.add(line4);

        Line line5 = new Line(x1+8,y1-13,x1+12,y1+3);
        House.add(line5);

        return House;
    }

    @Override
    public ArrayList<Shape> DrawTree(double x1, double y1) {
        ArrayList<Shape> Tree = new ArrayList<Shape>();

        Line line1 = new Line(x1,y1,x1+4,y1-18);
        Tree.add(line1);
        Line line2 = new Line(x1+4,y1-18,x1+8,y1-19);
        Tree.add(line2);
        Line line3 = new Line(x1+4,y1-18,x1+6,y1-23);
        Tree.add(line3);
        Line line4 = new Line(x1+4,y1-16,x1+3,y1-24);
        Tree.add(line4);

        Line line5 = new Line(x1,y1,x1-4,y1-18);
        Tree.add(line5);
        Line line6 = new Line(x1-4,y1-18,x1-8,y1-19);
        Tree.add(line6);
        Line line7 = new Line(x1-4,y1-18,x1-6,y1-23);
        Tree.add(line7);
        Line line8 = new Line(x1-4,y1-16,x1-3,y1-24);
        Tree.add(line8);
        return Tree;
    }

    @Override
    public ArrayList<Shape> DrawWaterSource(double x1, double y1) {
        ArrayList<Shape> WaterSource = new ArrayList<Shape>();

        Arc arc = new Arc();
        arc.setCenterX(x1);
        arc.setCenterY(y1);
        arc.setRadiusX(WaterSourceHeight/2.0);
        arc.setRadiusY(WaterSourceWidth/2.0);
        arc.setStartAngle(0.0);
        arc.setLength(100000.0);
        arc.setType(ArcType.OPEN);
        arc.setStroke(Color.BLACK);
        arc.setFill(Color.TRANSPARENT);

        WaterSource.add(arc);
        return WaterSource;
    }

    @Override
    public String getTerrainColor() {
        return TerrainColor;
    }
}
