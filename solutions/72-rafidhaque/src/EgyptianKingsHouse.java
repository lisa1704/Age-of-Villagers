import javafx.scene.Group;
import javafx.scene.shape.Line;

public class EgyptianKingsHouse extends DrawHouse {
    public EgyptianKingsHouse(Group g) {
        super(g);
    }

    @Override
    public void draw() {
        Line line1 = new Line(x, y + 14, x + 8, y);
        Line line2 = new Line(x + 10, y + 16, x + 8, y);
        Line line3 = new Line(x + 16, y + 10, x + 8, y);
        Line line4 = new Line(x, y + 14, x + 10, y + 16);
        Line line5 = new Line(x + 16, y + 10, x + 10, y + 16);
        g.getChildren().addAll(line1, line2, line3, line4, line5);
        drawOuterLayer();
    }
}
