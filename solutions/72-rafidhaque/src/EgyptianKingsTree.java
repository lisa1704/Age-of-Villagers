import javafx.scene.Group;
import javafx.scene.shape.Line;

public class EgyptianKingsTree extends DrawTree {
    public EgyptianKingsTree(Group g) {
        super(g);
    }

    @Override
    public void draw() {
        Line line1 = new Line(x, y, x + 8, y + 12);
        Line line2 = new Line(x + 16, y, x + 8, y + 12);
        Line line3 = new Line(x + 4, y + 6, x + 6, y);
        Line line4 = new Line(x + 12, y + 6, x + 9, y);
        Line line5 = new Line( x + 8, y + 12, x + 8, y + 24);
        g.getChildren().addAll(line1, line2, line3, line4, line5);
        drawOuterLayer();
    }
}
