package Project.Controllers;

import Project.Utilities.Village;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.ComboBox;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.*;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

import javax.swing.*;
import javax.swing.filechooser.FileSystemView;
import java.io.*;

import java.net.URL;
import java.util.ResourceBundle;

public class VillageView_controller implements Initializable {
    @FXML public TextField VillageNameField;
    @FXML public ComboBox NationList = new ComboBox();
    @FXML private Pane DrawingCanvas;
    public String flag;

    @Override
    public void initialize(URL location, ResourceBundle resources) {
        NationList.getItems().addAll(("Bangladeshi Farmers"),("Arab Bedouins"),("Egyptian Kings"),("Inuit Hunters"));
        DrawingCanvas.setOnMouseClicked(new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent event) {
                double x1 = event.getSceneX();
                double y1 = event.getSceneY();
                System.out.println(x1);
                System.out.println(y1);
                if(flag == "Tree"){
//                    Line l1 = new Line(x1,y1,x1-10,y1+20);
//                    Line l2 = new Line(x1,y1,x1+10,y1+20);
//                    Line l3 = new Line(x1-10,y1+20,x1+10,y1+20);
//                    DrawingCanvas.getChildren().addAll(l1,l2,l3);
                    DrawTree(x1,y1,16,24);
                }
                else if (flag == "House"){
//                    Line line1 = new Line(x1,y1,x1+16,y1);
//                    Line line2 = new Line(x1,y1,x1,y1+16);
//                    Line line3 = new Line(x1+16,y1,x1+16,y1+16);
//                    Line line4 = new Line(x1,y1+16,x1+16,y1+16);
//                    DrawingCanvas.getChildren().addAll(line1,line2,line3,line4);

                    DrawHouse(x1,y1,16,16);
                }
                else if(flag == "WaterSource"){
//                    Circle c = new Circle(x1,y1,10);
//                    DrawingCanvas.getChildren().addAll(c);
                    DrawWaterBody(x1,y1,24,16);
                }
            }
        });
    }


    public void save_village(ActionEvent actionEvent) throws IOException {
        SaveVillage();
        System.out.println("File Write done");
    }


    public void Open_new_village(ActionEvent actionEvent) {
        File selectedFile = null;
        final JFrame iFRAME = new JFrame();
        iFRAME.setAlwaysOnTop(true);
        iFRAME.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        iFRAME.setLocationRelativeTo(null);
        iFRAME.requestFocus();

        JFileChooser fileChooser = new JFileChooser(FileSystemView.getFileSystemView());
        int returnValue = fileChooser.showOpenDialog(iFRAME);
        iFRAME.dispose();
        if (returnValue == JFileChooser.APPROVE_OPTION) {
            selectedFile = fileChooser.getSelectedFile();
            try {
                FileInputStream file = new FileInputStream(selectedFile.getAbsolutePath());
                ObjectInputStream in = new ObjectInputStream(file);
//                JSONObject obj = (JSONObject) in.readObject();
                Village village = (Village)in.readObject();

                System.out.println(village.Name+" of Nation "+ village.Nation);
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        else {
            System.out.println("No File Selected");
        }
        System.out.println("File read done");
    }

    public void SaveVillage() throws IOException {
        String FileName = VillageNameField.getText() + ".aov";
        Village village = new Village(VillageNameField.getText(), (String) NationList.getValue());
        try {
            FileOutputStream file = new FileOutputStream("SavedFiles/"+FileName);
            ObjectOutputStream out = new ObjectOutputStream(file);
            out.writeObject(village);

        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public void TreePressed(ActionEvent actionEvent){
        DrawingCanvas.setStyle("-fx-background-color: GREEN");
        flag = "Tree";
    }

    public void HousePressed(ActionEvent actionEvent) {
        flag = "House";
    }

    public void WaterPressed(ActionEvent actionEvent) {
        flag = "WaterSource";
    }

    public void DrawTree(double x, double y, double width, double height){
        System.out.println("Tree!");
        Arc arc = new Arc();
        arc.setCenterX(x);
        arc.setCenterY(y);
        arc.setRadiusX(width/2);
        arc.setRadiusY((width/2)+2);
        arc.setType(ArcType.OPEN);
        arc.setStroke(Color.BLACK);
        arc.setStrokeWidth(1);
        arc.setFill(Color.TRANSPARENT);
        arc.setStartAngle(0.0);
        arc.setLength(1000.0);

        Line l1 = new Line(x-1,y,x+1,y);
        Line l2 = new Line(x-1,y+15,x+1,y+15);
        Line l3 = new Line(x-1,y,x-1,y+15);
        Line l4 = new Line(x+1,y,x+1,y+15);

        DrawingCanvas.getChildren().addAll(arc,l1,l2,l3,l4);
    }

    public void DrawHouse(double x, double y, double width, double height){
        double halfWidth = width/2;
        double halfHeight = height/2;
        Line l1 = new Line(x-halfWidth,y,x+halfWidth,y);
        Line l2 = new Line(x-halfWidth,y+halfHeight,x+halfWidth,y+halfHeight);
        Line l3 = new Line(x-halfWidth,y,x-halfWidth,y+halfWidth);
        Line l4 = new Line(x+halfWidth,y,x+halfWidth,y+halfWidth);
        Line l5 = new Line(x-halfWidth,y,x,y-halfHeight);
        Line l6 = new Line(x+halfWidth,y,x,y-halfHeight);
        DrawingCanvas.getChildren().addAll(l1,l2,l3,l4,l5,l6);
    }

    public void DrawWaterBody(double x, double y, double width, double height){
        Line l1 = new Line(x,y,x+(width/4),y+(height/2));
        Line l2 = new Line(x+(width/4),y+(height/2),x+(width/2),y);
        Line l3 = new Line(x+(width/2),y,x+(3*width/4),y+(height/2)-2);
        Line l4 = new Line(x+(3*width/4),y+(height/2)-2,x+width,y-(height/3));
        Line l5 = new Line(x+width,y-(height/3),x+(3*width/5),y-(height/2));
        Line l6 = new Line(x+(3*width/5),y-(height/2),x+(width/2)-2,y-4);
        Line l7 = new Line(x+(width/2)-2,y-4,x+(width/2)-2,y-(height/2));
        Line l8 = new Line(x+(width/2)-2,y-(height/2),x+(width/4),y-(height/2));
        Line l9 = new Line(x+(width/4),y-(height/2),x,y);
        DrawingCanvas.getChildren().addAll(l1,l2,l3,l4,l5,l6,l7,l8,l9);
    }
}