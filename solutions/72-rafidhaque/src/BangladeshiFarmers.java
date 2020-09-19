import javafx.scene.Group;

public class BangladeshiFarmers implements INation {

    String nationName = "BangladeshiFarmers";
    Group drawSpace;
    DrawHouse house;
    DrawTree tree;
    DrawWater water;

    public BangladeshiFarmers(Group drawSpace) {
        this.drawSpace = drawSpace;
        house = new BangladeshiFarmersHouse(drawSpace);
        tree = new BangladeshiFarmersTree(drawSpace);
        water = new BangladeshiFarmersWater(drawSpace, 24, 16);
    }
}

