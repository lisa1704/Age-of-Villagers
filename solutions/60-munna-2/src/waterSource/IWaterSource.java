package waterSource;

import javafx.scene.canvas.Canvas;
import shapes.Point;

public interface IWaterSource {
    void draw_water_resource(Canvas canvas);
    void calculating_points(Point main_point);
}
