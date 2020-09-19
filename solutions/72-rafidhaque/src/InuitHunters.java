import javafx.scene.Group;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;

public class InuitHunters implements INation {
    String nationName = "Inuit Hunters";
    Group drawSpace;
    DrawHouse house;
    DrawTree tree;
    DrawWater water;

    public InuitHunters(Group drawSpace) {
        this.drawSpace = drawSpace;
        Rectangle fillColor = new Rectangle(0,0, 600, 400);
        fillColor.setFill(Color.WHITE);
        drawSpace.getChildren().add(fillColor);
        this.house = new InuitHuntersHouse(drawSpace);
        this.tree = new NoTree(drawSpace);
        this.water = new NoWater(drawSpace, 0, 0);
    }
}

