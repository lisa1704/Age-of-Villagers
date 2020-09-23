package House;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;

import java.awt.*;

public class ArabBedouinHouse implements IHouse{
    public GraphicsContext gc;

    @Override
    public void draw(Canvas canvas, Point point) {
        gc=canvas.getGraphicsContext2D();
        gc.beginPath();
        gc.moveTo(point.getX(),point.getY());
        gc.lineTo(point.getX()+20,point.getY());
        gc.lineTo(point.getX()+40,point.getY()-10);
        gc.lineTo(point.getX()+20+10,point.getY()-30);
        gc.lineTo(point.getX()+10,point.getY()-20);
        gc.moveTo(point.getX()+20,point.getY());
        gc.lineTo(point.getX()+10,point.getY()-20);
        gc.lineTo(point.getX(),point.getY());
        gc.closePath();
        gc.stroke();
    }
}
