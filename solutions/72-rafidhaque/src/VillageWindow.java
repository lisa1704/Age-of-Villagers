import javax.swing.*;
import java.awt.*;
import java.awt.event.MouseEvent;
import java.awt.event.MouseListener;

public class VillageWindow extends JPanel {
    private final String gameName = "Age of Villagers";
    private String villageName;
    private String nationName;
    private JFrame f = new JFrame("Title");
    private JPanel p = new JPanel();
    int mouseX;
    int mouseY;


    public int getMouseX() {
        return mouseX;
    }

    public void setMouseX(int mouseX) {
        this.mouseX = mouseX;
    }

    public int getMouseY() {
        return mouseY;
    }

    public void setMouseY(int mouseY) {
        this.mouseY = mouseY;
    }


    public VillageWindow(String villageName, String nationName) {
        this.villageName = villageName;
        this.nationName = nationName;
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



        p.addMouseListener(new MouseListener() {
                @Override
                public void mouseClicked(MouseEvent e) {
                    whenClicked(e);
                }

                @Override
                public void mousePressed(MouseEvent e) {

                }

                @Override
                public void mouseReleased(MouseEvent e) {

                }

                @Override
                public void mouseEntered(MouseEvent e) {

                }

                @Override
                public void mouseExited(MouseEvent e) {

            }
        });


    }

    public void showWindow() {
        p.setPreferredSize(new Dimension(600, 400));
        f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        f.add(this);
        f.add(this.p, BorderLayout.WEST);
        f.setSize(800, 400);
        f.setVisible(true);
    }

    public void whenClicked(MouseEvent e) {
        int x=e.getX();
        int y=e.getY();
        System.out.println(x+","+y);
    }


}