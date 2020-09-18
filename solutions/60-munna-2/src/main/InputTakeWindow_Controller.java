package main;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import javafx.stage.Stage;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;

public class InputTakeWindow_Controller extends Controller implements Initializable {

    @FXML
    private TextField villageName_Text;

    @FXML
    private TextField countryName_text;

    @FXML
    private Button CreateNewVillage_Button;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        try {
            Stage stage = new Stage();
            FXMLLoader loader = new FXMLLoader(Main.class.getResource("main_page.fxml"));
            Parent root = loader.load();
            stage.setTitle("Age of Villagers");
            stage.setScene(new Scene(root, 1000, 500));
            stage.setResizable(false);
            stage.show();

        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    @FXML
    void CreateNewVillage(ActionEvent event) throws IOException {
        vn_label.setText(villageName_Text.getText());
        cn_label.setText(countryName_text.getText());
        Stage stage2 = (Stage) CreateNewVillage_Button.getScene().getWindow();
        stage2.close();
        
    }
}
