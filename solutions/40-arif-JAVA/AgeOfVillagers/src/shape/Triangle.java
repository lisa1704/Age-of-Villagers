package shape;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;

public class Triangle implements IShape {
    GraphicsContext graphicsContext;
    double x,y;
    public Triangle(GraphicsContext graphicsContext, double x, double y) {
        this.graphicsContext = graphicsContext;
        this.x = x;
        this.y = y;
    }

    @Override
    public void draw() {

        graphicsContext.strokeLine(x,y,x+15,y+15);
        graphicsContext.strokeLine(x,y,x-15,y-15);
        graphicsContext.strokeLine(x+30,y+30,x-15,y-15);
        System.out.println(x+" " +y);
    }
}
