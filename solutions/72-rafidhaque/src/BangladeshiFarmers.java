import javafx.scene.Group;
import javafx.scene.shape.Line;

public class BangladeshiFarmers implements INation {

    Group drawSpace;

    public BangladeshiFarmers(Group drawSpace) {
        this.drawSpace = drawSpace;
    }

    @Override
    public void house(DrawHouse drawHouse) {
        drawHouse.drawOuterLayer();
        Rectangle rectangle = new Rectangle(drawSpace, drawHouse.x+1, drawHouse.y+8, drawHouse.x + 15, drawHouse.y + 15);
        Line line1 = new Line(drawHouse.x + 1, drawHouse.y + 8, drawHouse.x + 8, drawHouse.y);
        Line line2 = new Line(drawHouse.x + 15, drawHouse.y + 8, drawHouse.x + 8, drawHouse.y);
        rectangle.draw();
        drawSpace.getChildren().addAll(line1, line2);
    }

    @Override
    public void tree(DrawTree drawTree) {
        drawTree.drawOuterLayer();
        Circle circle = new Circle(drawSpace, drawTree.x + 8, drawTree.y + 8, 7);
        Rectangle rectangle = new Rectangle(drawSpace, drawTree.x + 8, drawTree.y + 8, drawTree.x + 10, drawTree.y + 24);
        circle.draw();
        rectangle.draw();
    }

    @Override
    public void waterSource(DrawWater drawWater) {
        drawWater.drawOuterLayer();
        Line line1 = new Line(drawWater.x + 1, drawWater.y + 8, drawWater.x + 8, drawWater.y);
        Line line2 = new Line(drawWater.x + 8, drawWater.y, drawWater.x + 15, drawWater.y + 8);
        Line line3 = new Line(drawWater.x + 15, drawWater.y + 8, drawWater.x + 24, drawWater.y + 10);
        Line line4 = new Line(drawWater.x + 24, drawWater.y + 10, drawWater.x + 10, drawWater.y + 16);
        Line line5 = new Line( drawWater.x + 10, drawWater.y + 16, drawWater.x + 1, drawWater.y + 8);
        drawSpace.getChildren().addAll(line1, line2, line3, line4, line5);
    }
}

