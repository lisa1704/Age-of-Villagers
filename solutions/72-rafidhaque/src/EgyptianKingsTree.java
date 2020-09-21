import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class EgyptianKingsTree extends DrawTree {

    @Override
    public ArrayList<Shape> draw() {
        Line line1 = new Line(x, y, x + 8, y + 12);
        Line line2 = new Line(x + 16, y, x + 8, y + 12);
        Line line3 = new Line(x + 4, y + 6, x + 6, y);
        Line line4 = new Line(x + 12, y + 6, x + 9, y);
        Line line5 = new Line( x + 8, y + 12, x + 8, y + 24);

        ArrayList<Shape> lines = new ArrayList<>();
        lines.add(line1);
        lines.add(line2);
        lines.add(line3);
        lines.add(line4);
        lines.add(line5);

        return lines;
    }
}
