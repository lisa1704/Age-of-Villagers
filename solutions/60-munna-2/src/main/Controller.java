package main;

import house.BangladeshiFarmersHouse;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.RadioButton;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.Pane;
import javafx.stage.Stage;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;

public class Controller implements Initializable {
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

    public static Label vn_label,cn_label;

    @FXML
    public Canvas drawing_space_canvas;


    @FXML
    void newVillage_Button_Clicked(ActionEvent event) throws IOException {
        Stage stage = (Stage) newVillage_Button.getScene().getWindow();
        FXMLLoader loader = new FXMLLoader(Main.class.getResource("InputTakeWindow.fxml"));
        Parent root = loader.load();
        stage.setTitle("Age of Villagers");
        stage.setScene(new Scene(root, 600, 310));
        stage.setResizable(false);
        stage.show();
    }


    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        cn_label = country_name;
        vn_label = village_name;
    }

    public void House_Button_Clicked(ActionEvent actionEvent) {
        BangladeshiFarmersHouse bangladeshiFarmersHouse = new BangladeshiFarmersHouse();
        bangladeshiFarmersHouse.draw_house(drawing_space_canvas);
    }
}
