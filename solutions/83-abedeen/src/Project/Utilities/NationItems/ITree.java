package Project.Utilities.NationItems;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public interface ITree {
    double TreeWidth = 16;
    double TreeHeight = 24;
    ArrayList<Shape> drawTree(double x, double y);
}
