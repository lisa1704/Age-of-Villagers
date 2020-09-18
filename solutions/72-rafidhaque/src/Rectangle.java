import javafx.scene.Group;
import javafx.scene.shape.Line;

public class Rectangle {
    private int x1, y1, x2, y2;
    public Line line1, line2, line3, line4;
    Group root;

    public Rectangle(Group root, int startX, int startY, int endX, int endY) {
        this.root = root;
        this.x1 = startX;
        this.y1 = startY;
        this.x2 = endX;
        this.y2 = endY;
        line1 = new Line(x1, y1, x1, y2);
        line2 = new Line(x1, y1, x2, y1);
        line3 = new Line(x2, y1, x2, y2);
        line4 = new Line(x1, y2, x2, y2);
    }

    public void draw() {
        root.getChildren().addAll(line1, line2, line3, line4);
    }


}
