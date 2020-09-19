import javafx.scene.Group;
import javafx.scene.shape.Line;

public class DrawHouse implements IDrawComponent{
    double x, y;

    public void setX(double x) {
        this.x = x;
    }

    public void setY(double y) {
        this.y = y;
    }

    Group g;
    Rectangle outerArea;
    public DrawHouse(Group g) {
        this.g = g;
    }

    @Override
    public void draw() {
        Rectangle rectangle = new Rectangle(g, x+1, y+8, x+15, y+15);
        Line line1 = new Line(x + 1, y + 8, x + 8, y);
        Line line2 = new Line(x + 15, y + 8, x + 8, y);
        rectangle.draw();
        g.getChildren().addAll(line1, line2);
    }

    @Override
    public void drawOuterLayer() {
        outerArea = new Rectangle(g, x, y, x + 16, y + 16);
        draw();
        outerArea.draw();
    }

    @Override
    public String toString() {
        return "DrawHouse";
    }
}
