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
        this.house = new InuitHuntersHouse();
        this.tree = new NoTree();
        this.water = new NoWater( 0, 0);
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

