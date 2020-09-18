import javafx.scene.Group;

public class DrawHouse implements IDrawComponent{
    int x, y;
    Group g;
    Rectangle outerArea;
    public DrawHouse(Group g, int currentX, int currentY) {
        this.x = currentX;
        this.y = currentY;
        this.g = g;
    }

    @Override
    public void draw() {

    }

    @Override
    public void drawOuterLayer() {
        outerArea = new Rectangle(g, x, y, x + 16, y + 16);
        outerArea.draw();
    }
}
