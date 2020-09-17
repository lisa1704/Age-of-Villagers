import javax.swing.*;

public abstract class DrawComponent implements IDrawComponent {
    JPanel p;

    public DrawComponent(JPanel p) {
        this.p = p;
    }
}
