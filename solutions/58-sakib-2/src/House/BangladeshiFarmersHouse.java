package House;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;

import java.awt.Point;


public class BangladeshiFarmersHouse implements IHouse {
    public GraphicsContext gc;

    @Override
    public void draw(Canvas canvas, Point point) {
        gc=canvas.getGraphicsContext2D();
        gc.fillRect(point.getX(),point.getY(),20,10);
        gc.beginPath();
        gc.moveTo(point.getX(),point.getY());
        gc.lineTo(point.getX()+10.0,point.getY()-10.0);
        gc.lineTo(point.getX()+20.0,point.getY());
        gc.closePath();
        //gc.setLineWidth(1);
        gc.stroke();
    }
}
