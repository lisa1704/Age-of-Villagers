import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class EgyptianKingsHouse extends DrawHouse {

    @Override
    public ArrayList<Shape> draw() {
        Line line1 = new Line(x, y + 14, x + 8, y);
        Line line2 = new Line(x + 10, y + 16, x + 8, y);
        Line line3 = new Line(x + 16, y + 10, x + 8, y);
        Line line4 = new Line(x, y + 14, x + 10, y + 16);
        Line line5 = new Line(x + 16, y + 10, x + 10, y + 16);
        ArrayList<Shape> lines = new ArrayList<>();
        lines.add(line1);
        lines.add(line2);
        lines.add(line3);
        lines.add(line4);
        lines.add(line5);

        return lines;
    }
}
