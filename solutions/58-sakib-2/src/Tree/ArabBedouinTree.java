package Tree;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;

import java.awt.*;

public class ArabBedouinTree implements ITree {
    GraphicsContext gc;
    @Override
    public void draw(Canvas canvas, Point point) {
        gc=canvas.getGraphicsContext2D();
        gc.beginPath();
        gc.moveTo(point.getX(),point.getY());
        gc.lineTo(point.getX()-1,point.getY());
        gc.lineTo(point.getX()-1,point.getY()+15);
        gc.lineTo(point.getX()+1,point.getY()+15);
        gc.lineTo(point.getX()+1,point.getY());
        gc.lineTo(point.getX(),point.getY());
        gc.lineTo(point.getX()+7,point.getY()-7);
        gc.moveTo(point.getX(),point.getY());
        gc.lineTo(point.getX()+3,point.getY()-10);
        gc.moveTo(point.getX(),point.getY());
        gc.lineTo(point.getX(),point.getY()-13);
        gc.moveTo(point.getX(),point.getY());
        gc.lineTo(point.getX()-3,point.getY()-10);
        gc.moveTo(point.getX(),point.getY());
        gc.lineTo(point.getX()-7,point.getY()-7);
        gc.closePath();
        gc.stroke();
    }
}
