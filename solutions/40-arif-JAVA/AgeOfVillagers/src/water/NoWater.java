package water;

import javafx.scene.canvas.Canvas;
import javafx.scene.control.RadioButton;

public class NoWater implements IWater {
    @Override
    public void draw(Canvas canvas, RadioButton radioButton) {
        System.out.println("no water");
    }
}
