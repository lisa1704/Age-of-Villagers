package Tree;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.shape.ArcType;

import java.awt.*;

public class BangladeshiFarmersTree implements ITree {
    GraphicsContext gc;

    @Override
    public void draw(Canvas canvas, Point point) {
        gc=canvas.getGraphicsContext2D();
        gc.strokeArc(point.getX(),point.getY(),20,10,0,360, ArcType.ROUND);
        gc.beginPath();
        gc.moveTo(point.getX()+10,point.getY()+5);
        gc.lineTo(point.getX()+9,point.getY()+30);
        gc.lineTo(point.getX()+11,point.getY()+30);
        gc.lineTo(point.getX()+11,point.getY()+5);
        gc.closePath();
        gc.stroke();
    }
}
