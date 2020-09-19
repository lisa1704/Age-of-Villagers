package house;

import javafx.scene.canvas.Canvas;
import shapes.Point;


public interface IHouse {
    void draw_house(Canvas canvas);
    void calculating_points(Point main_point);
}
