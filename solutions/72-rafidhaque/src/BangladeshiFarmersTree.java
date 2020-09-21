import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class BangladeshiFarmersTree extends DrawTree{


    public ArrayList<Shape> draw() {
        Circle circle = new Circle(x + 8, y + 8, 7);
        Rectangle rectangle = new Rectangle(x + 8, y + 8, x + 10, y + 24);

        ArrayList<Shape> lines = rectangle.draw();
        lines.add(circle.draw());

        return lines;
    }
}
