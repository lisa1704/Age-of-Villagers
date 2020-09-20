import javafx.scene.Group;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;

public class EgyptianKings implements INation {
    String nationName = "Egyptian Kings";
    Group drawSpace;
    DrawHouse house;
    DrawTree tree;
    DrawWater water;

    public EgyptianKings(Group drawSpace) {
        this.drawSpace = drawSpace;
        Rectangle fillColor = new Rectangle(0,0, 600, 400);
        fillColor.setFill(Color.LIGHTYELLOW);
        drawSpace.getChildren().add(fillColor);
        house = new EgyptianKingsHouse(drawSpace);
        tree = new EgyptianKingsTree(drawSpace);
        water = new EgyptianKingsWater(drawSpace, 12, 12);
    }
}
