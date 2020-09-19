import javafx.scene.Group;
import javafx.scene.shape.Line;

public class DrawWater implements IDrawComponent{
    double x, y, width, height;
    Group g;
    Rectangle outerArea;

    @Override
    public void setX(double x) {
        this.x = x;
    }

    @Override
    public void setY(double y) {
        this.y = y;
    }

    public DrawWater(Group g, double width, double height) {
        this.g = g;
        this.width = width;
        this.height = height;
    }

    @Override
    public void draw() {
        Line line1 = new Line(x + 1, y + 8, x + 8, y);
        Line line2 = new Line(x + 8, y, x + 15, y + 8);
        Line line3 = new Line(x + 15, y + 8, x + 24, y + 10);
        Line line4 = new Line(x + 24, y + 10, x + 10, y + 16);
        Line line5 = new Line( x + 10, y + 16, x + 1, y + 8);
        g.getChildren().addAll(line1, line2, line3, line4, line5);
    }

    @Override
    public void drawOuterLayer() {
        outerArea = new Rectangle(g, x, y, x + width, y + height);
        outerArea.draw();
    }

    @Override
    public String toString() {
        return "DrawWater";
    }
}
