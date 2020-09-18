package project.Controllers;

import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;

import java.awt.*;
import java.awt.event.ActionEvent;
import java.net.URL;
import java.util.ResourceBundle;

import javafx.scene.Group;
import javafx.scene.Parent;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Line;


public class VillageViewController implements Initializable {
    @FXML
    private TextField Village_Name;
    @FXML private Button WaterSource = new Button();
    @FXML private Pane DrawPane;
    private double x1,y1,x2,y2;

    @Override
    public void initialize(URL location, ResourceBundle resources) {

    }

    public void WaterSourceClicked(javafx.event.ActionEvent actionEvent) {
        try{

            Circle circle = new Circle(500,200,10,Color.BLACK);
            DrawPane.getChildren().add(circle);


        }
        catch (Exception e){
            e.printStackTrace();
        }
    }
}
