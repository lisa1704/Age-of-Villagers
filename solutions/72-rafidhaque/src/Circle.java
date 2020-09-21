import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;
import javafx.scene.shape.Shape;

public class Circle {
    Arc arc;
    double x, y, diameter;

    public Circle(double centerX, double centerY, double diameter) {
        this.x = centerX;
        this.y = centerY;
        this.diameter = diameter;
        arc = new Arc(x, y, diameter, diameter, 270, 360);
        arc.setFill(Color.TRANSPARENT);
        arc.setStroke(Color.BLACK);
        arc.setType(ArcType.ROUND);
    }

    public Shape draw() {
        return arc;
    }

}
