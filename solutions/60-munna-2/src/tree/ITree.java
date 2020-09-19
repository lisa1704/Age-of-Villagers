package tree;

import javafx.scene.canvas.Canvas;
import shapes.Point;

public interface ITree {
    void draw_Tree(Canvas canvas);
    void calculating_points(Point main_point);
}
