import javax.swing.*;

public abstract class DrawComponent implements IDrawComponent {
    JPanel p;
    int startX, startY;

    public DrawComponent(JPanel p, int x, int y) {
        this.p = p;
        this.startX = x;
        this.startY = y;
    }
}

