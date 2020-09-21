package Project.Utilities.NationItems;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public interface IHouse extends IAsset{
    double houseWidth = 16;
    double houseHeight = 16;
    ArrayList<Shape> drawAsset(double x, double y);
}
