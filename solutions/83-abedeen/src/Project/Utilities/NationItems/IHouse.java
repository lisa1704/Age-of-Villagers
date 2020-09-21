package Project.Utilities.NationItems;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public interface IHouse {
    double houseWidth = 16;
    double houseHeight = 16;
    ArrayList<Shape> drawHouse(double x, double y);
}
