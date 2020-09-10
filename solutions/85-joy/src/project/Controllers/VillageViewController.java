package project.Controllers;

import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.net.URL;
import java.util.ResourceBundle;

import javafx.scene.Parent;
import javafx.scene.control.TextField;


public class VillageViewController implements Initializable {
    @FXML
    private TextField Village_Name;
    @FXML private Button WaterSource = new Button();

    @Override
    public void initialize(URL location, ResourceBundle resources) {

    }

    public void WaterSourceClicked(javafx.event.ActionEvent actionEvent) {
        try{

            System.out.println("NIGGA!");
        }
        catch (Exception e){
            e.printStackTrace();
        }
    }
}
