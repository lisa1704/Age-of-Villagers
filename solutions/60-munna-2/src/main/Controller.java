package main;

import com.sun.prism.shader.Solid_ImagePattern_Loader;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.RadioButton;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.Pane;
import javafx.stage.Stage;

public class Controller {
    @FXML
    private Pane main_pane;

    @FXML
    private AnchorPane drawing_space;

    @FXML
    private Button newVillage_Button;

    @FXML
    private Button openVillage_Button;

    @FXML
    private Button saveVillage_Button;

    @FXML
    private RadioButton water_RadioButton;

    @FXML
    private RadioButton tree_RadioButton;

    @FXML
    private RadioButton house_RadioButton;

    @FXML
    private Label country_name;

    @FXML
    private Label village_name;

    @FXML
    void newVillage_Button_Clicked(ActionEvent event) {
        Stage stage = (Stage) newVillage_Button.getScene().getWindow();






    }


}
