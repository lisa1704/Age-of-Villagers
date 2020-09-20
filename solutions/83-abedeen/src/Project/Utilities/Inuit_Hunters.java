package Project.Utilities;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Inuit_Hunters implements INations{
    private String TerrainColor = "WHITE";
    @Override
    public ArrayList<Shape> drawHouse(double x, double y) {
        return null;
    }

    @Override
    public ArrayList<Shape> drawTree(double x, double y) {
        ArrayList<Shape> tree = new ArrayList<>();
        return tree;
    }

    @Override
    public ArrayList<Shape> drawWaterBody(double x, double y) {
        ArrayList<Shape> WB = new ArrayList<>();
        return WB;
    }

    @Override
    public String GetTerrainColor() {
        return TerrainColor;
    }
}
