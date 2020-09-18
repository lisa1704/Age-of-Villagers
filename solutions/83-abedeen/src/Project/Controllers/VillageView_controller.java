package Project.Controllers;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;

import java.awt.*;
import java.net.URL;
import java.util.ResourceBundle;

public class VillageView_controller implements Initializable {
    @FXML
    private TextField village_name;

    @Override
    public void initialize(URL location, ResourceBundle resources) {

    }

    public void TreePressed(ActionEvent actionEvent) {
        System.out.println("Trees everywhere!!!!");
    }
}
