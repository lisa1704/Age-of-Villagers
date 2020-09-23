import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class NoWater extends DrawWater{
    public NoWater(double width, double height) {
        super(width, height);
    }

    @Override
    public ArrayList<Shape> draw() {
        ArrayList<Shape> arrayList = new ArrayList<>();
        return arrayList;
    }
    @Override
    public ArrayList<Shape> draw(double x, double y) {
        ArrayList<Shape> arrayList = new ArrayList<>();
        return arrayList;
    }
}
