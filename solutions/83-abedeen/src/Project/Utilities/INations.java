package Project.Utilities;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public interface INations {
    double houseWidth = 16;
    double houseHeight = 16;
    double TreeWidth = 16;
    double TreeHeight = 24;
    String TerrainColor = null;
    ArrayList<Shape> drawHouse(double x, double y);
    ArrayList<Shape> drawTree(double x, double y);
    ArrayList<Shape> drawWaterBody(double x, double y);
    String GetTerrainColor();
}