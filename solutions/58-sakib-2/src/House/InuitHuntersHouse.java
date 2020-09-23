package House;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.shape.ArcType;

import java.awt.*;

public class InuitHuntersHouse implements IHouse {
    GraphicsContext gc;

    @Override
    public void draw(Canvas canvas, Point point) {
        gc=canvas.getGraphicsContext2D();
        gc.strokeArc(point.getX()+15,point.getY()+2,10,5,0,180, ArcType.ROUND);
        gc.strokeArc(point.getX()+10,point.getY(),20,10,0,180, ArcType.ROUND);
    }
}
