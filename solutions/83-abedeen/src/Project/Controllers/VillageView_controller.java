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
import javafx.scene.shape.Circle;
import javafx.scene.shape.Line;
import javafx.scene.shape.TriangleMesh;
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
                    Line l1 = new Line(x1,y1,x1-10,y1+20);
                    Line l2 = new Line(x1,y1,x1+10,y1+20);
                    Line l3 = new Line(x1-10,y1+20,x1+10,y1+20);
                    DrawingCanvas.getChildren().addAll(l1,l2,l3);
                }
                else if (flag == "House"){
                    Line line1 = new Line(x1,y1,x1+20,y1);
                    Line line2 = new Line(x1,y1,x1,y1+20);
                    Line line3 = new Line(x1+20,y1,x1+20,y1+20);
                    Line line4 = new Line(x1,y1+20,x1+20,y1+20);
                    DrawingCanvas.getChildren().addAll(line1,line2,line3,line4);
                }
                else if(flag == "WaterSource"){
                    Circle c = new Circle(x1,y1,10);
                    DrawingCanvas.getChildren().addAll(c);
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
        flag = "Tree";
    }

    public void HousePressed(ActionEvent actionEvent) {
        flag = "House";
    }

    public void WaterPressed(ActionEvent actionEvent) {
        flag = "WaterSource";
    }
}