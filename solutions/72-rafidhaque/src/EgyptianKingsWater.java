import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class EgyptianKingsWater extends DrawWater {
    public EgyptianKingsWater(int width, int height) {
        super(width, height);
    }

    @Override
    public ArrayList<Shape> draw() {
        Circle water = new Circle(x + 6, y + 6, 6);

        ArrayList<Shape> lines = new ArrayList<>();
        lines.add(water.draw());

        return lines;
    }
}
