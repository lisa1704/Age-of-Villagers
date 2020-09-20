package project.Utilities;

import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class EgyptianKings implements INation{
    private  String TerrainColor = "#F9D423";

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
        return null;
    }

    @Override
    public ArrayList<Shape> DrawWaterSource(double x1, double y1) {
        return null;
    }

    @Override
    public String getTerrainColor() {
        return TerrainColor;
    }
}
