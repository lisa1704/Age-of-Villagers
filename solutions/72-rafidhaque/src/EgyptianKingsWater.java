import javafx.scene.Group;

public class EgyptianKingsWater extends DrawWater {
    public EgyptianKingsWater(Group g, int width, int height) {
        super(g, width, height);
    }

    @Override
    public void draw() {
        Circle water = new Circle(g, x + 6, y + 6, 6);
        drawOuterLayer();
        water.draw();
    }
}
