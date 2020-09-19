package project.Controllers;

import javafx.beans.InvalidationListener;
import javafx.collections.ListChangeListener;
import javafx.collections.ObservableList;
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
import javafx.scene.shape.Circle;
import java.lang.String;

import java.io.*;
import java.net.URL;
import java.util.*;

import javafx.scene.shape.Line;
import javafx.scene.shape.Rectangle;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import project.Utilities.Villages;

import javax.swing.*;
import javax.swing.filechooser.FileSystemView;


public class VillageViewController implements Initializable {
    @FXML public ComboBox NationDropDown = new ComboBox();
    @FXML private TextField Village_Name;
    @FXML private Pane DrawPane;
    public int Flag = 0;



    @Override
    public void initialize(URL location, ResourceBundle resources) {
        NationDropDown.getItems().addAll(("Bangladeshi Farmers"),("Arab Beduin"),("Egyptian Kings"),("Egyptian Knights"));
        DrawPane.setOnMouseClicked(new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent event) {
                if(Flag == 0){
                    Line line = new Line(event.getSceneX(),event.getSceneY(),event.getSceneX()+20.0,event.getSceneY()+20.0);
                    DrawPane.getChildren().addAll(line);
                }
                else if(Flag == 1){
                    Circle circle = new Circle(event.getSceneX(),event.getSceneY(),10,Color.GRAY);
                    DrawPane.getChildren().addAll(circle);
                }
                else if(Flag == 2){
                    DrawHouse(event.getSceneX(), event.getSceneY(), 16.0,16.0);
                }
            }
        });
    }

    public void WaterSourceClicked(javafx.event.ActionEvent actionEvent) {
        try{

            Circle circle = new Circle(500,200,10,Color.BLACK);
            DrawPane.getChildren().add(circle);
            System.out.println(NationDropDown.getValue());
            System.out.println(Village_Name.getText());

        }
        catch (Exception e){
            e.printStackTrace();
        }
    }

    public void SaveVillage(ActionEvent actionEvent) {
        String Filename = Village_Name.getText() + ".aov";
//        JSONObject obj = new JSONObject();
//        obj.put("Village_Name",Village_Name.getText());
//        obj.put("Nation",NationDropDown.getValue());
        Villages villages = new Villages(Village_Name.getText(), (String) NationDropDown.getValue());
        try {
            FileOutputStream file = new FileOutputStream("SavedVillages/"+Filename);
            ObjectOutputStream out = new ObjectOutputStream(file);
            out.writeObject(villages);
        } catch (Exception e) {
            e.printStackTrace();
        }


    }

    public void OpenVillage(ActionEvent actionEvent) {
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
                Villages villages = (Villages)in.readObject();

                System.out.println(villages.VillageName);
                System.out.println(villages.Nation);
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        else {
            System.out.println("No File Selected!");
        }

    }

    public void SelectTree(ActionEvent actionEvent) {
        this.Flag = 1;
        System.out.println("TREE SELECTED!");
    }

    public void SelectHouse(ActionEvent actionEvent) {
        this.Flag = 2;
        System.out.println("HOUSE SELECTED!");
    }

    public void DrawHouse(double x1, double y1, double height, double width){
        //Upper Triangle..
        Line line1 = new Line(x1,y1,x1+width,y1);
        Line line2 = new Line(x1,y1,x1+(width/2.0),y1-(height/2.0));
        Line line3 = new Line(x1+width,y1,x1+(width/2.0),y1-(height/2.0));
        //Lower Rectangle
        Line line4 = new Line(x1,y1,x1,y1+height);
        Line line5 = new Line(x1,y1+height,x1+width,y1+height);
        Line line6 = new Line(x1+width,y1+height,x1+width,y1);

        DrawPane.getChildren().addAll(line1,line2,line3,line4,line5,line6);

    }
}
