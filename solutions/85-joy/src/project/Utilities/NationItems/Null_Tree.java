package project.Utilities.NationItems;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Null_Tree implements ITree{
    @Override
    public ArrayList<Shape> drawAsset(double x, double y) {
        return new ArrayList<Shape>();
    }
}
