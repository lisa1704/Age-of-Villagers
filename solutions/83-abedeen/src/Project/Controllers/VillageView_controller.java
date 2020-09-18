package Project.Controllers;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.layout.Pane;
import javafx.scene.shape.Line;

import java.awt.*;
import java.net.URL;
import java.util.ResourceBundle;

public class VillageView_controller implements Initializable {
    @FXML private TextField village_name;
    @FXML private Pane DrawingCanvas;

    @Override
    public void initialize(URL location, ResourceBundle resources) {

    }

    public void TreePressed(ActionEvent actionEvent) {

        Line simpleLine = new Line(25,25,65,65);
        DrawingCanvas.getChildren().add(simpleLine);
    }
}
