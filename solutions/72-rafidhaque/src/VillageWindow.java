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

        g.setFont(new Font("TimesRoman", Font.PLAIN, 20));
        g.setColor(Color.BLACK);
        g.drawString(gameName, 620, 50);

        g.setFont(new Font("TimesRoman", Font.PLAIN, 13));
        g.drawString(this.villageName, 620, 90);
        g.drawString(this.nationName, 620, 130);
    }

    public void showWindow() {
        JFrame f = new JFrame("Title");
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.add(this);
        f.setSize(800, 400);
        f.setVisible(true);
    }

}

