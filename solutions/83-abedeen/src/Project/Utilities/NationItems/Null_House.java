package Project.Utilities.NationItems;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Null_House implements IHouse{
    @Override
    public ArrayList<Shape> drawAsset(double x, double y) {
        return new ArrayList<>();
    }
}
