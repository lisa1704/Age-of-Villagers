import javafx.scene.shape.Line;
import javafx.scene.shape.Shape;

import java.util.ArrayList;

public class Rectangle {
    private double x1, y1, x2, y2;
    public Line line1, line2, line3, line4;

    public Rectangle(double startX, double startY, double endX, double endY) {
        this.x1 = startX;
        this.y1 = startY;
        this.x2 = endX;
        this.y2 = endY;
        line1 = new Line(x1, y1, x1, y2);
        line2 = new Line(x1, y1, x2, y1);
        line3 = new Line(x2, y1, x2, y2);
        line4 = new Line(x1, y2, x2, y2);
    }

    public ArrayList<Shape> draw() {
        ArrayList<Shape> arrayList = new ArrayList<>();
        arrayList.add(line1);
        arrayList.add(line2);
        arrayList.add(line3);
        arrayList.add(line4);
        return arrayList;
    }


}
