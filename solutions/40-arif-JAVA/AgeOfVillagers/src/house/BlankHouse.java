package house;


import javafx.scene.canvas.Canvas;

public class BlankHouse implements IHouse {
    @Override
    public void draw(Canvas canvas, String item) {

        System.out.println("blank house");
    }
}
