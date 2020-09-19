import javafx.scene.Group;
import javafx.scene.paint.Color;
import javafx.scene.shape.Arc;
import javafx.scene.shape.ArcType;

public class Circle {
    Group g;
    Arc arc;
    double x, y, diameter;

    public Circle(Group g, double centerX, double centerY, double diameter) {
        this.g = g;
        this.x = centerX;
        this.y = centerY;
        this.diameter = diameter;
        arc = new Arc(x, y, diameter, diameter, 270, 360);
        arc.setFill(Color.TRANSPARENT);
        arc.setStroke(Color.BLACK);
        arc.setType(ArcType.ROUND);
    }

    public void draw() {
        g.getChildren().addAll(arc);
    }

}
