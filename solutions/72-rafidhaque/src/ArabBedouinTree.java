import javafx.scene.Group;
import javafx.scene.shape.Line;

public class ArabBedouinTree extends DrawTree {
    public ArabBedouinTree(Group g) {
        super(g);
    }

    @Override
    public void draw() {
        Line line1 = new Line(x, y, x + 8, y + 12);
        Line line2 = new Line(x + 16, y, x + 8, y + 12);
        Line line3 = new Line(x, y + 12, x + 16, y + 12);
        Line line4 = new Line(x + 8, y + 12, x + 8, y);
        Rectangle rectangle = new Rectangle(g,x + 8, y + 12, x + 10, y + 24);
        rectangle.draw();
        g.getChildren().addAll(line1, line2, line3, line4);
        drawOuterLayer();
    }
}
