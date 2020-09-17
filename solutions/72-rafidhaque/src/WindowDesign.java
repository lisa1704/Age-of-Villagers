import javax.swing.*;
import java.awt.*;

public class WindowDesign extends JPanel{
    private JFrame f;
    private JPanel p;
    private final String gameName = "Age of Villagers";
    private String villageName;
    private String nationName;

    public WindowDesign(JFrame f, JPanel p, String villageName, String nationName) {
        this.villageName = villageName;
        this.nationName = nationName;
        this.f = f;
        this.p = p;
    }

    public void paintComponent(Graphics g){
        super.paintComponent(g);
        this.setBackground(Color.WHITE);

        g.setFont(new Font("TimesRoman", Font.PLAIN, 20));
        g.setColor(Color.BLACK);
        g.drawString(this.gameName, 20, 50);

        g.setFont(new Font("TimesRoman", Font.PLAIN, 13));
        g.drawString(this.villageName, 20, 90);
        g.drawString(this.nationName, 20, 130);

        JButton treebutton=new JButton("Tree");
        treebutton.setFont(new Font("Arial", Font.PLAIN, 10));
        treebutton.setBounds(620,160,70,30);
        f.add(treebutton);

        JButton housebutton=new JButton("House");
        housebutton.setFont(new Font("Arial", Font.PLAIN, 10));
        housebutton.setBounds(700,160,70,30);
        f.add(housebutton);

        JButton waterbutton=new JButton("Water Source");
        waterbutton.setFont(new Font("Arial", Font.PLAIN, 10));
        waterbutton.setBounds(625,195,140,30);
        f.add(waterbutton);

        JButton savebutton=new JButton("Save Village");
        savebutton.setFont(new Font("Arial", Font.PLAIN, 10));
        savebutton.setBounds(625,260,140,30);
        f.add(savebutton);

        JButton newbuttton=new JButton("New\nVillage");
        newbuttton.setFont(new Font("Arial", Font.PLAIN, 10));
        newbuttton.setMargin(new Insets(1,1,1,1));
        newbuttton.setBounds(620,300,70,30);
        f.add(newbuttton);

        JButton openbutton=new JButton("Open\nVillage");
        openbutton.setFont(new Font("Arial", Font.PLAIN, 10));
        openbutton.setMargin(new Insets(1,1,1,1));
        openbutton.setBounds(700,300,70,30);
        f.add(openbutton);

        g.setColor(Color.BLACK);
        g.drawLine(600, 0, 600, 400);
        g.drawLine(0, 0, 0, 400);
        g.drawLine(0, 0, 800, 0);
        g.drawLine(800, 0, 800, 400);
        g.drawLine(0, 400, 800, 400);

        p.setPreferredSize(new Dimension(600, 400));
        f.add(this.p, BorderLayout.WEST);
    }
}
