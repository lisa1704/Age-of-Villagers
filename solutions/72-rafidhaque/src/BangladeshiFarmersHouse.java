import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class BangladeshiFarmersHouse extends DrawHouse{

    public ArrayList<Shape> draw() {
        Rctangle rectangle = new Rctangle(super.x+1, super.y+8, super.x + 15, super.y + 15);
        Line line1 = new Line(super.x + 1, super.y + 8, super.x + 8, super.y);
        Line line2 = new Line(super.x + 15, super.y + 8, super.x + 8, super.y);
        ArrayList<Shape> rectLines = rectangle.draw();
        rectLines.add(line1);
        rectLines.add(line2);

        return rectLines;
    }


}
