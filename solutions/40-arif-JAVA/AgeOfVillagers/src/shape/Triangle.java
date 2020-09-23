package shape;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;

public class Triangle implements IShape {
    double x,y;
    public Triangle(double x, double y) {
        this.x = x;
        this.y = y;
    }

    @Override
    public void draw(GraphicsContext graphicsContext) {

        new Line(x,y,x+10,y+10).draw(graphicsContext);
        new Line(x,y,x-10,y+10).draw(graphicsContext);
        new Line(x+10,y+10,x-10,y+10).draw(graphicsContext);



        System.out.println(x+" " +y);
    }
}
