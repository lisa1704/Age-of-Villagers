package project.Utilities.NationItems;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public interface ITree {
    double TreeWidth = 16.0;
    double TreeHeight = 24.0;

    ArrayList<Shape> DrawTree(double x1, double y1);
}
