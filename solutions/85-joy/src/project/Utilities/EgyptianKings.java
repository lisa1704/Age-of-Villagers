package project.Utilities;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class EgyptianKings implements INation{
    private  String TerrainColor = "#F9D423";

    public EgyptianKings(){
        super();
    }


    @Override
    public ArrayList<Shape> DrawHouse(double x1, double y1) {
        return null;
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
