package project.Utilities;

import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class InuitHunters implements INation{
    private  String TerrainColor = "WHITE";

    public InuitHunters(){
        super();
    }

    @Override
    public ArrayList<Shape> DrawHouse(double x1, double y1) {
        ArrayList<Shape> House = new ArrayList<Shape>();

        Arc arc1 = new Arc();
        arc1.setCenterX(x1);
        arc1.setCenterY(y1);
        arc1.setRadiusX(HouseHeight/2.0);
        arc1.setRadiusY(HouseWidth/2.0);
        arc1.setStartAngle(0.0);
        arc1.setLength(180.0);
        arc1.setType(ArcType.ROUND);
        arc1.setStroke(Color.BLACK);
        arc1.setFill(Color.TRANSPARENT);
        House.add(arc1);

        Arc arc2 = new Arc();
        arc2.setCenterX(x1);
        arc2.setCenterY(y1);
        arc2.setRadiusX((HouseHeight/2.0)-5);
        arc2.setRadiusY((HouseWidth/2.0)-5);
        arc2.setStartAngle(0.0);
        arc2.setLength(180.0);
        arc2.setType(ArcType.ROUND);
        arc2.setStroke(Color.BLACK);
        arc2.setFill(Color.TRANSPARENT);
        House.add(arc2);
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
