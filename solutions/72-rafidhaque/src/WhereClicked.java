import javax.swing.*;
import java.awt.event.MouseListener;

public class WhereClicked {
    int x, y;
    JPanel p;
    MouseListener mouseListener;

    public WhereClicked(JPanel p, MouseListener mouseListener) {
        this.p = p;
        this.mouseListener = mouseListener;
    }



}
