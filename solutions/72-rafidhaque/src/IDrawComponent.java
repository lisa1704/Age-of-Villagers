import javafx.scene.shape.Shape;

import java.util.ArrayList;

public interface IDrawComponent extends java.io.Serializable{

    ArrayList<Shape> draw();

    ArrayList<Shape> draw(double x, double y);

    void setX(double x);

    void setY(double y);

    double getX();

    double getY();
}
