package project.Utilities;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class InuitHunters implements INation{
    private  String TerrainColor = "WHITE";

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
        ArrayList<Shape> WaterSource = new ArrayList<Shape>();
        
    }

    @Override
    public String getTerrainColor() {
        return TerrainColor;
    }
}
