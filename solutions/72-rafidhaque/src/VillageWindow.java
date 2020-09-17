import javax.swing.*;
import java.awt.*;

public class VillageWindow extends JPanel {
    private final String gameName = "Age of Villagers";
    private String villageName;
    private String nationName;
    private JFrame f = new JFrame("Title");
    private JPanel p = new JPanel();


    public VillageWindow(String villageName, String nationName) {
        this.villageName = villageName;
        this.nationName = nationName;
    }

    WindowDesign windowDesign = new WindowDesign(f, p, villageName, nationName);

    public void paintComponent(Graphics g){
        windowDesign.paintComponent(g);
    }

    public void showWindow() {
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.add(this);
        f.setSize(800, 400);
        f.setVisible(true);
    }



}

