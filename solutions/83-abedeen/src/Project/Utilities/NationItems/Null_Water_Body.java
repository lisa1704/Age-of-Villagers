package Project.Utilities.NationItems;

import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Null_Water_Body implements IWaterBody{
    @Override
    public ArrayList<Shape> drawWaterBody(double x, double y) {
        return new ArrayList<>();
    }
}
