package house;

import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.input.MouseEvent;
import shapes.Point;

public class BangladeshiFarmersHouse implements IHouse {
    private Canvas canvas;

    private Point top_center;
    private Point top_left;
    private Point top_right;
    private Point bottom_left;
    private Point bottom_right;


    @Override
    public void draw_house() {
        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();

        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<MouseEvent>() {
                    @Override
                    public void handle(MouseEvent event) {
                            calculating_points(new Point((int) event.getX(), (int) event.getY()));
                            graphicsContext.strokeLine(top_center.x, top_center.y, top_left.x, top_left.y);
                            graphicsContext.strokeLine(top_center.x, top_center.y, top_right.x, top_right.y);
                            graphicsContext.strokeLine(top_left.x, top_left.y, top_right.x, top_right.y);
                            graphicsContext.strokeLine(top_left.x, top_left.y, bottom_left.x, bottom_left.y);
                            graphicsContext.strokeLine(bottom_left.x, bottom_left.y, bottom_right.x, bottom_right.y);
                            graphicsContext.strokeLine(bottom_right.x, bottom_right.y, top_right.x, top_right.y);

                    }
                });
    }
    

    @Override
    public void calculating_points(Point main_point) {
        top_center = new Point(main_point.x, main_point.y + 6);
        bottom_right = new Point(main_point.x + 6, main_point.y - 6);
        top_left = new Point(main_point.x - 6, main_point.y );
        top_right = new Point(main_point.x + 6, main_point.y);
        bottom_left = new Point(main_point.x - 6, main_point.y - 6);
    }


}
