import javax.swing.*;
import java.awt.*;

public class VillageWindow extends JPanel {
    private final String gameName = "Age of Villagers";
    private String villageName;
    private String nationName;

    public VillageWindow(String villageName, String nationName) {
        this.villageName = villageName;
        this.nationName = nationName;
    }

    public void paintComponent(Graphics g){
        super.paintComponent(g);
        this.setBackground(Color.WHITE);

        g.setFont(new Font("TimesRoman", Font.PLAIN, 10));
        g.setColor(Color.BLACK);
    }

    public void showWindow() {
        JFrame f = new JFrame("Title");
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.add(this);
        f.setSize(800, 400);
        f.setVisible(true);
    }

}

