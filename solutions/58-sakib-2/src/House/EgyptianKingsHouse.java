package House;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;

import java.awt.*;

public class EgyptianKingsHouse implements IHouse {
    GraphicsContext gc;

    @Override
    public void draw(Canvas canvas, Point point) {
        gc=canvas.getGraphicsContext2D();
        gc.beginPath();
        gc.moveTo(point.getX(),point.getY());
        gc.lineTo(point.getX()+5,point.getY()+5);
        gc.lineTo(point.getX()+10,point.getY());
        gc.lineTo(point.getX()+5,point.getY()-15);
        gc.lineTo(point.getX(),point.getY());
        gc.moveTo(point.getX()+5,point.getY()+5);
        gc.lineTo(point.getX()+5,point.getY()-15);
        gc.lineTo(point.getX(),point.getY());
        gc.closePath();
        gc.stroke();
    }
}
