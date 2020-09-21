package Project.Utilities.NationItems;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Null_Tree implements ITree{
    @Override
    public ArrayList<Shape> drawTree(double x, double y) {
        return new ArrayList<>();
    }
}
