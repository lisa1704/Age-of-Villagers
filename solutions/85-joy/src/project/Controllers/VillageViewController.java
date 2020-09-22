package project.Controllers;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;

import javafx.scene.control.ComboBox;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.Pane;

import javafx.scene.shape.*;

import java.lang.String;

import java.io.*;
import java.net.URL;
import java.util.*;

import project.Utilities.NationFactory;
import project.Utilities.Villages;

import javax.swing.*;
import javax.swing.filechooser.FileSystemView;


public class VillageViewController implements Initializable {
    @FXML public ComboBox NationDropDown = new ComboBox();
    @FXML private TextField Village_Name;
    @FXML private Pane DrawPane;


    public NationFactory nationFactory;
    public int Flag = 0;
    public ArrayList<Shape> Object ;



    @Override
    public void initialize(URL location, ResourceBundle resources) {
        NationDropDown.getItems().addAll(("Bangladeshi Farmers"),("Arab Bedouin"),("Egyptian Kings"),("Inuit Hunters"));
        DrawPane.setOnMouseClicked(new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent event) {
                if(Flag == 1){
                    Object = nationFactory.drawTree(event.getSceneX(),event.getSceneY());
                    DrawShape(Object);
                }
                else if(Flag == 2){
                    Object = nationFactory.drawHouse(event.getSceneX(),event.getSceneY());
                    DrawShape(Object);
                }
                else if(Flag == 3){
                    Object = nationFactory.drawWaterSource(event.getSceneX(),event.getSceneY());
                    DrawShape(Object);
//                    DrawPane.getChildren().clear();
                }
            }
        });
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

    public void SelectWaterSource(ActionEvent actionEvent) {
        this.Flag = 3;
        System.out.println("WATERSOURCE SELECTED!");
    }

    public void DrawShape(ArrayList<Shape> ShapeObject){
        for (Shape x : ShapeObject){
            DrawPane.getChildren().addAll(x);
        }
    }

    public void NationChanged(ActionEvent actionEvent) {
        nationFactory = new NationFactory((String) NationDropDown.getValue());
        DrawPane.setStyle("-fx-background-color:"+nationFactory.getTerrainColor((String) NationDropDown.getValue()));

    }
}
