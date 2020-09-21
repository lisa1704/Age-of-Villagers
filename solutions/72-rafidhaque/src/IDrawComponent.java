import javafx.scene.shape.Shape;

import java.util.ArrayList;

public interface IDrawComponent {

    ArrayList<Shape> draw();

    void setX(double x);

    void setY(double y);
}
