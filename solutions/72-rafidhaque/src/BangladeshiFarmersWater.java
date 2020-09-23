import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class BangladeshiFarmersWater extends DrawWater{
    public BangladeshiFarmersWater(double width, double height) {
        super(width, height);
    }

    public ArrayList<Shape> draw() {
        Line line1 = new Line(x + 1, y + 8, x + 8, y);
        Line line2 = new Line(x + 8, y, x + 15, y + 8);
        Line line3 = new Line(x + 15, y + 8, x + 24, y + 10);
        Line line4 = new Line(x + 24, y + 10, x + 10, y + 16);
        Line line5 = new Line( x + 10, y + 16, x + 1, y + 8);

        ArrayList<Shape> lines = new ArrayList<>();
        lines.add(line1);
        lines.add(line2);
        lines.add(line3);
        lines.add(line4);
        lines.add(line5);

        return lines;
    }

    public ArrayList<Shape> draw(double x, double y) {
        Line line1 = new Line(x + 1, y + 8, x + 8, y);
        Line line2 = new Line(x + 8, y, x + 15, y + 8);
        Line line3 = new Line(x + 15, y + 8, x + 24, y + 10);
        Line line4 = new Line(x + 24, y + 10, x + 10, y + 16);
        Line line5 = new Line( x + 10, y + 16, x + 1, y + 8);

        ArrayList<Shape> lines = new ArrayList<>();
        lines.add(line1);
        lines.add(line2);
        lines.add(line3);
        lines.add(line4);
        lines.add(line5);

        return lines;
    }

}
