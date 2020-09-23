package shape;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

public class Rectangle implements IShape {
    GraphicsContext graphicsContext;
    double x1,y1,h, w;
    public Rectangle(GraphicsContext graphicsContext, double x1, double y1, double h, double w) {
        this.graphicsContext = graphicsContext;
        this.x1 = x1;
        this.y1 = y1;
        this.h = h;
        this.w = w;
    }

    @Override
    public void draw() {
        new Line(graphicsContext, x1,y1,x1+w,y1).draw();
        new Line(graphicsContext, x1+w,y1,x1+w,y1+h).draw();
        new Line(graphicsContext, x1+w,y1+h,x1,y1+h).draw();
        new Line(graphicsContext, x1,y1+h,x1,y1).draw();
    }
}
