package house;


import javafx.scene.canvas.Canvas;
import javafx.scene.control.RadioButton;

public class BlankHouse implements IHouse {
    @Override
    public void draw(Canvas canvas, RadioButton radioButton) {
        System.out.println("blank house");
    }
}
