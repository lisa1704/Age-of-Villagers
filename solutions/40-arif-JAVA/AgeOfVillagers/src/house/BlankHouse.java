package house;


import javafx.scene.canvas.Canvas;

public class BlankHouse implements IHouse {
    boolean active = false;
    @Override
    public void draw(Canvas canvas, String item) {

        System.out.println("blank house");
    }

    @Override
    public void releaseCanvas() {

    }

    @Override
    public void getCanvas() {

    }
}
