package project.Controllers;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.TextField;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;

import java.io.*;
import java.net.URL;
import java.util.ResourceBundle;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

import javax.swing.*;
import javax.swing.filechooser.FileSystemView;


public class VillageViewController implements Initializable {
    @FXML public ChoiceBox NationDropDown;
    @FXML private TextField Village_Name;
    @FXML private Pane DrawPane;



    @Override
    public void initialize(URL location, ResourceBundle resources) {

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
        JSONObject obj = new JSONObject();
        obj.put("Village_Name",Village_Name.getText());
        obj.put("Nation",NationDropDown.getValue());

//        FileWriter file = null;
//        try {
//            file = new FileWriter("SavedVillages/"+Filename);
//            file.write(obj.toJSONString());
//            file.close();
//        } catch (IOException e) {
//            e.printStackTrace();
//        }

        try {
            FileOutputStream file = new FileOutputStream("SavedVillages/"+Filename);
            ObjectOutputStream out = new ObjectOutputStream(file);
            out.writeObject(obj.toJSONString());
        } catch (Exception e) {
            e.printStackTrace();
        }


    }

    public void OpenVillage(ActionEvent actionEvent) {
        File selectedFile = null;
        final JFrame iFRAME = new JFrame();
        iFRAME.setAlwaysOnTop(true);    // ****
        iFRAME.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        iFRAME.setLocationRelativeTo(null);
        iFRAME.requestFocus();

        JFileChooser fileChooser = new JFileChooser(FileSystemView.getFileSystemView());
        int returnValue = fileChooser.showOpenDialog(iFRAME);
        iFRAME.dispose();
        if (returnValue == JFileChooser.APPROVE_OPTION) {
            selectedFile = fileChooser.getSelectedFile();
            // Display selected file in console
            System.out.println(selectedFile.getAbsolutePath());
        }
        else {
            System.out.println("No File Selected!");
        }


        try {
            FileInputStream file = new FileInputStream(selectedFile.getAbsolutePath());
            ObjectInputStream in = new ObjectInputStream(file);
            JSONObject obj = (JSONObject) in.readObject();
            System.out.println(obj.toJSONString());
        } catch (Exception e) {
            e.printStackTrace();
        }

    }
}
