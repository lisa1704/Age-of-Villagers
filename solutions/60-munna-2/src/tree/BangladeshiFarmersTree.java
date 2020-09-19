package tree;

import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.input.MouseEvent;
import shapes.Circle_Shape;
import shapes.Point;
import shapes.Rectangle_Shape;

public class BangladeshiFarmersTree implements ITree {
    private Point circle_center,bottomLeft,topLeft, bottomRight, topRight;

    @Override
    public void calculating_points(Point main_point) {
        circle_center = new Point(main_point.x - 8, main_point.y - 12);
        topLeft = new Point(main_point.x + 2, main_point.y - 4);
        bottomRight = new Point(main_point.x - 2, main_point.y + 12);
    }

    @Override
    public void draw_Tree(Canvas canvas) {
        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();

        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<MouseEvent>(){
                    @Override
                    public void handle(MouseEvent event) {
                        calculating_points(new Point((int)event.getX(), (int)event.getY()));
                        new Circle_Shape(circle_center,16,graphicsContext).draw();
                        new Rectangle_Shape(topLeft,bottomRight,graphicsContext).draw();
                    }
                });
    }
}
