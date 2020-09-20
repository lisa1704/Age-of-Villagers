import javafx.scene.Group;
import javafx.scene.shape.Line;

public class ArabBedouinHouse extends DrawHouse {
    public ArabBedouinHouse(Group g) {
        super(g);
    }

    @Override
    public void draw() {
        Line line1 = new Line(x, y + 16, x + 8, y + 4);
        Line line2 = new Line(x + 12, y + 16, x + 8, y + 4);
        Line line3 = new Line(x + 12, y + 16, x, y + 16);
        Line line4 = new Line(x + 8, y + 4, x + 16, y);
        Line line5 = new Line(x + 12, y + 16, x + 16, y + 12);
        Line line6 = new Line(x + 16, y, x + 16, y + 12);

        super.g.getChildren().addAll(line1, line2, line3, line4, line5, line6);
        drawOuterLayer();
    }
}
