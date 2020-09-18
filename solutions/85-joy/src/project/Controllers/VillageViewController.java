package project.Controllers;

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
import javafx.scene.layout.Pane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Line;


public class VillageViewController implements Initializable {
    @FXML
    private TextField Village_Name;
    @FXML private Button WaterSource = new Button();
    @FXML private Pane DrawPane;

    @Override
    public void initialize(URL location, ResourceBundle resources) {

    }

    public void WaterSourceClicked(javafx.event.ActionEvent actionEvent) {
        try{

            System.out.println("NIGGA!");
//            FXMLLoader fxmlLoader = new FXMLLoader(getClass().getResource("project/Views/VillageView.fxml"));
//            fxmlLoader.setRoot(this);
//            fxmlLoader.setController(this);
//            Canvas canvas = new Canvas(600,400);
            Circle circle = new Circle(200,200,10,Color.BLACK);
            DrawPane.getChildren().add(circle);


//            g.drawLine(100,200,300,400);

        }
        catch (Exception e){
            e.printStackTrace();
        }
    }
}
