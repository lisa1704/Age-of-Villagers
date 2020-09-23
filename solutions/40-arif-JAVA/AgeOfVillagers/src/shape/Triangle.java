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

        new Line(graphicsContext, x,y,x+10,y+10).draw();
        new Line(graphicsContext, x,y,x-10,y+10).draw();
        new Line(graphicsContext, x+10,y+10,x-10,y+10).draw();



//        graphicsContext.strokeLine(x,y,x+15,y+15);
//        graphicsContext.strokeLine(x,y,x-15,y+15);
//        graphicsContext.strokeLine(x+15,y+15,x-10,y+10);

        System.out.println(x+" " +y);
    }
}
