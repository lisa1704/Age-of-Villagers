package Tree;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;

import java.awt.*;

public class EgyptianKingsTree implements ITree {
    GraphicsContext gc;
    @Override
    public void draw(Canvas canvas, Point point) {
        gc=canvas.getGraphicsContext2D();
        gc.beginPath();
        gc.moveTo(point.getX(),point.getY());
        gc.lineTo(point.getX()-8,point.getY()-12);
        gc.moveTo(point.getX(),point.getY());
        gc.lineTo(point.getX()+8,point.getY()-12);
        gc.moveTo(point.getX()-4,point.getY()-7);
        gc.lineTo(point.getX()-10,point.getY()-10);
        gc.moveTo(point.getX()-4,point.getY()-7);
        gc.lineTo(point.getX()-2,point.getY()-12);

        gc.moveTo(point.getX()+4,point.getY()-7);
        gc.lineTo(point.getX()+10,point.getY()-10);
        gc.moveTo(point.getX()+4,point.getY()-7);
        gc.lineTo(point.getX()+2,point.getY()-12);
        gc.closePath();
        gc.stroke();
    }
}
