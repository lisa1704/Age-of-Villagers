import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class ArabBedouinTree extends DrawTree {

    @Override
    public ArrayList<Shape> draw() {
        Line line1 = new Line(x, y, x + 8, y + 12);
        Line line2 = new Line(x + 16, y, x + 8, y + 12);
        Line line3 = new Line(x, y + 12, x + 16, y + 12);
        Line line4 = new Line(x + 8, y + 12, x + 8, y);
        Rctangle rectangle = new Rctangle(x + 8, y + 12, x + 10, y + 24);

        ArrayList<Shape> lines = rectangle.draw();
        lines.add(line1);
        lines.add(line2);
        lines.add(line3);
        lines.add(line4);

        return lines;
    }
    @Override
    public ArrayList<Shape> draw(double x, double y) {
        Line line1 = new Line(x, y, x + 8, y + 12);
        Line line2 = new Line(x + 16, y, x + 8, y + 12);
        Line line3 = new Line(x, y + 12, x + 16, y + 12);
        Line line4 = new Line(x + 8, y + 12, x + 8, y);
        Rctangle rectangle = new Rctangle(x + 8, y + 12, x + 10, y + 24);

        ArrayList<Shape> lines = rectangle.draw();
        lines.add(line1);
        lines.add(line2);
        lines.add(line3);
        lines.add(line4);

        return lines;
    }
}
