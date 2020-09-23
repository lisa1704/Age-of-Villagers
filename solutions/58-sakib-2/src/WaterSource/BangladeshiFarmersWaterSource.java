package WaterSource;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;

import java.awt.*;

public class BangladeshiFarmersWaterSource implements IWaterSource {
    public GraphicsContext gc;
    @Override
    public void draw(Canvas canvas, Point point) {
        gc=canvas.getGraphicsContext2D();
        gc.beginPath();
        gc.moveTo(point.getX(),point.getY());
        gc.lineTo(point.getX()+5,point.getY()+5);
        gc.lineTo(point.getX()+9,point.getY()+0);
        gc.lineTo(point.getX()+11,point.getY()+4);
        gc.lineTo(point.getX()+13,point.getY()-5);
        gc.lineTo(point.getX()+10,point.getY()-9);
        gc.lineTo(point.getX()+7,point.getY()-5);
        gc.lineTo(point.getX()+7,point.getY()-8);
        gc.lineTo(point.getX()+5,point.getY()-7);
        gc.lineTo(point.getX(),point.getY());
        gc.closePath();
        gc.stroke();

    }
}
