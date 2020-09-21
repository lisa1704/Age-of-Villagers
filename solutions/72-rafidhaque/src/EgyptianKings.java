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
        house = new EgyptianKingsHouse();
        tree = new EgyptianKingsTree();
        water = new EgyptianKingsWater(12, 12);
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
