import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class BangladeshiFarmersTree extends DrawTree{


    public ArrayList<Shape> draw() {
        Circle circle = new Circle(x + 8, y + 8, 7);
        Rctangle rectangle = new Rctangle(x + 8, y + 8, x + 10, y + 24);

        ArrayList<Shape> lines = rectangle.draw();
        lines.add(circle.draw());

        return lines;
    }
    public ArrayList<Shape> draw(double x, double y) {
        Circle circle = new Circle(x + 8, y + 8, 7);
        Rctangle rectangle = new Rctangle(x + 8, y + 8, x + 10, y + 24);

        ArrayList<Shape> lines = rectangle.draw();
        lines.add(circle.draw());

        return lines;
    }
}
