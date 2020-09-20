package Project.Utilities;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Egyptian_Kings implements INations{
    private double WaterBodyWidth = 12;
    private double WaterBodyheight = 12;
    private String TerrainColor = "yellow";
    public Egyptian_Kings(){
        super();
    }

    @Override
    public ArrayList<Shape> drawHouse(double x, double y) {
        return null;
    }

    @Override
    public ArrayList<Shape> drawTree(double x, double y) {
        return null;
    }

    @Override
    public ArrayList<Shape> drawWaterBody(double x, double y) {
        return null;
    }

    @Override
    public String GetTerrainColor() {
        return this.TerrainColor;
    }
}
