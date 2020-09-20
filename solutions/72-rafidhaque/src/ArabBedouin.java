import javafx.scene.Group;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;

public class ArabBedouin implements INation {

    String nationName = "Arab Bedouin";
    Group drawSpace;
    DrawHouse house;
    DrawTree tree;
    DrawWater water;

    public ArabBedouin(Group drawSpace) {
        this.drawSpace = drawSpace;
        Rectangle fillColor = new Rectangle(0,0, 600, 400);
        fillColor.setFill(Color.LIGHTYELLOW);
        drawSpace.getChildren().add(fillColor);
        house = new ArabBedouinHouse(drawSpace);
        tree = new ArabBedouinTree(drawSpace);
        water = new NoWater(drawSpace, 0, 0);
    }
}
