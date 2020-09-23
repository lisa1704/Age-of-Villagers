import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class ArabBedouinHouse extends DrawHouse {

    @Override
    public ArrayList<Shape> draw() {
        Line line1 = new Line(x, y + 16, x + 8, y + 4);
        Line line2 = new Line(x + 12, y + 16, x + 8, y + 4);
        Line line3 = new Line(x + 12, y + 16, x, y + 16);
        Line line4 = new Line(x + 8, y + 4, x + 16, y);
        Line line5 = new Line(x + 12, y + 16, x + 16, y + 12);
        Line line6 = new Line(x + 16, y, x + 16, y + 12);

        ArrayList<Shape> lines = new ArrayList<>();
        lines.add(line1);
        lines.add(line2);
        lines.add(line3);
        lines.add(line4);
        lines.add(line5);
        lines.add(line6);

        return lines;
    }
    @Override
    public ArrayList<Shape> draw(double x, double y) {
        Line line1 = new Line(x, y + 16, x + 8, y + 4);
        Line line2 = new Line(x + 12, y + 16, x + 8, y + 4);
        Line line3 = new Line(x + 12, y + 16, x, y + 16);
        Line line4 = new Line(x + 8, y + 4, x + 16, y);
        Line line5 = new Line(x + 12, y + 16, x + 16, y + 12);
        Line line6 = new Line(x + 16, y, x + 16, y + 12);

        ArrayList<Shape> lines = new ArrayList<>();
        lines.add(line1);
        lines.add(line2);
        lines.add(line3);
        lines.add(line4);
        lines.add(line5);
        lines.add(line6);

        return lines;
    }
}
