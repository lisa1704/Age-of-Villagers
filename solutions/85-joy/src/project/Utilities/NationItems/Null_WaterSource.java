package project.Utilities.NationItems;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Null_WaterSource implements IWaterSource{
    @Override
    public ArrayList<Shape> drawAsset(double x, double y) {
        return new ArrayList<Shape>();
    }
}
