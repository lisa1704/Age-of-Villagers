package house;

import javafx.scene.canvas.Canvas;
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
