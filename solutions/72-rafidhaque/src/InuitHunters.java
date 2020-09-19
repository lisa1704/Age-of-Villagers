import javafx.scene.Group;

public class InuitHunters implements INation {
    String nationName = "BangladeshiFarmers";
    Group drawSpace;
    DrawHouse house;
    DrawTree tree;
    DrawWater water;

    public InuitHunters(Group drawSpace) {
        this.drawSpace = drawSpace;
        this.house = new InuitHuntersHouse(drawSpace);
        this.tree = tree;
        this.water = water;
    }
}

