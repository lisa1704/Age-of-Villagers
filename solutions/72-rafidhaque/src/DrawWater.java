import javafx.scene.Group;

public class DrawWater implements IDrawComponent{
    int x, y;
    Group g;
    Rectangle outerArea;
    public DrawWater(Group g, int currentX, int currentY) {
        this.x = currentX;
        this.y = currentY;
        this.g = g;
    }

    @Override
    public void draw() {
    }

    @Override
    public void drawOuterLayer() {
        outerArea = new Rectangle(g, x, y, x + 24, y + 24);
        outerArea.draw();
    }
}
