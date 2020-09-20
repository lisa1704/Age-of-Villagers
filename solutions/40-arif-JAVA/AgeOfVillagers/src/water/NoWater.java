package water;

import javafx.scene.canvas.Canvas;

public class NoWater implements IWater {
    @Override
    public void draw(Canvas canvas, String item) {
        System.out.println("no water");
    }
}
