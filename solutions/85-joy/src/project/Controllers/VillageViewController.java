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
            out.writeObject(obj);
        } catch (Exception e) {
            e.printStackTrace();
        }


    }
}
