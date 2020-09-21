package Project.Utilities.NationItems;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public interface ITree extends IAsset{
    double TreeWidth = 16;
    double TreeHeight = 24;
    ArrayList<Shape> drawAsset(double x, double y);
}
