import java.awt.event.MouseEvent;

public class WhereClicked {
    MouseEvent e;

    public WhereClicked(MouseEvent e, int x, int y) {
        this.e = e;
        x = mouseClickedx();
        y = mouseClickedy();
    }

    public int mouseClickedx() {
        int x=this.e.getX();
        return x;
    }

    public int mouseClickedy() {
        int y=this.e.getY();
        return y;
    }


}
