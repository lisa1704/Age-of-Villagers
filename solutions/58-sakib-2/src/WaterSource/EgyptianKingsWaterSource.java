package WaterSource;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.shape.ArcType;

import java.awt.*;

public class EgyptianKingsWaterSource implements IWaterSource {
    GraphicsContext gc;
    @Override
    public void draw(Canvas canvas, Point point) {
        gc=canvas.getGraphicsContext2D();
        gc.strokeArc(point.getX()+10,point.getY(),20,10,0,360, ArcType.ROUND);
    }
}
