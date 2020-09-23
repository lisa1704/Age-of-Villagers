package shape;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

public class Rectangle implements IShape {
    GraphicsContext graphicsContext;
    double x1,y1;
    public Rectangle(GraphicsContext graphicsContext, double x1, double y1) {
        this.graphicsContext = graphicsContext;
        this.x1 = x1;
        this.y1 = y1;
    }

    @Override
    public void draw() {
        new Line(graphicsContext, x1,y1,x1+10,y1).draw();
        new Line(graphicsContext, x1+10,y1,x1+10,y1+10).draw();
        new Line(graphicsContext, x1+10,y1+10,x1,y1+10).draw();
        new Line(graphicsContext, x1,y1+10,x1,y1).draw();
        
    }
}
