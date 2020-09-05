package sample;

import javafx.collections.FXCollections;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Button;

public class Controller {

    private void initialize() {
    }
    @FXML
    private Button newVillageBTN;

    @FXML
    void newVillageBTN(ActionEvent event) {
        System.out.println("okok");
    }

    @FXML
    void saveVillageBTN(ActionEvent event) {
        System.out.println("village saved");
    }

    @FXML
    void canvas(ActionEvent event) {
        System.out.println("canvas Clicked");
    }

}
