package Project.Utilities;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Null_Nation implements INations{
    private String TerrainColor = "WHITE";

    @Override
    public ArrayList<Shape> drawHouse(double x, double y) {
        ArrayList<Shape> noHouse = new ArrayList<>();
        return noHouse;
    }

    @Override
    public ArrayList<Shape> drawTree(double x, double y) {
        ArrayList<Shape> noTree = new ArrayList<>();
        return noTree;
    }

    @Override
    public ArrayList<Shape> drawWaterBody(double x, double y) {
        ArrayList<Shape> noWB = new ArrayList<>();
        return noWB;
    }

    @Override
    public String GetTerrainColor() {
        return TerrainColor;
    }
}
