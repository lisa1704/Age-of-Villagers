package project.Utilities;

import javafx.scene.shape.Shape;

import java.util.ArrayList;


public interface INation {
    double HouseWidth = 16.0;
    double HouseHeight = 16.0;
    double TreeWidth = 16.0;
    double TreeHeight = 24.0;


    ArrayList<Shape> DrawHouse(double x1, double y1);
    ArrayList<Shape> DrawTree(double x1,double y1);
    void DrawWaterSource();
    String getTerrainColor();

}
