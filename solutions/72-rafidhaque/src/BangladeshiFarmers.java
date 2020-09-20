import javafx.scene.Group;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;

public class BangladeshiFarmers implements INation {

    String nationName = "BangladeshiFarmers";
    Group drawSpace;
    DrawHouse house;
    DrawTree tree;
    DrawWater water;

    public BangladeshiFarmers(Group drawSpace) {
        this.drawSpace = drawSpace;
        Rectangle fillColor = new Rectangle(0,0, 600, 400);
        fillColor.setFill(Color.GREENYELLOW);
        drawSpace.getChildren().add(fillColor);
        house = new BangladeshiFarmersHouse(drawSpace);
        tree = new BangladeshiFarmersTree(drawSpace);
        water = new BangladeshiFarmersWater(drawSpace, 24, 16);
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

