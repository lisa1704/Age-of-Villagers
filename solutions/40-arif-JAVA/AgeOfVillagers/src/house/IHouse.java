package house;


import javafx.scene.canvas.Canvas;

public interface IHouse {
    void draw(Canvas canvas, String item);

    void releaseCanvas();

    void getCanvas();
}
