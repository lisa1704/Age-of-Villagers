package project.Utilities.NationItems;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public interface IHouse {
    double HouseWidth = 16.0;
    double HouseHeight = 16.0;

    ArrayList<Shape> DrawHouse(double x1, double y1);
}
