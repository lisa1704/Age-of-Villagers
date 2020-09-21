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
        house = new ArabBedouinHouse();
        tree = new ArabBedouinTree();
        water = new NoWater( 0, 0);
        drawSpace.getChildren().addAll(house.draw());
        drawSpace.getChildren().addAll(tree.draw());
        drawSpace.getChildren().addAll(water.draw());
    }

    public String getNationName() {
        return nationName;
    }

    public DrawHouse getHouse() {
        return house;
    }

    public DrawTree getTree() {
        return tree;
    }

    public DrawWater getWater() {
        return water;
    }
}
