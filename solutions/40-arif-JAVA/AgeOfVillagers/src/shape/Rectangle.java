package shape;

import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.paint.Color;

public class Rectangle implements IShape {
    double x1, y1, h, w;

    public Rectangle(double x1, double y1, double h, double w) {
        this.x1 = x1;
        this.y1 = y1;
        this.h = h;
        this.w = w;
    }

    @Override
    public void draw(GraphicsContext graphicsContext) {
        new Line(x1, y1, x1 + w, y1).draw(graphicsContext);
        new Line(x1 + w, y1, x1 + w, y1 + h).draw(graphicsContext);
        new Line(x1 + w, y1 + h, x1, y1 + h).draw(graphicsContext);
        new Line(x1, y1 + h, x1, y1).draw(graphicsContext);
    }
}
