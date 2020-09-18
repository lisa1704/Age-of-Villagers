package Project.Controllers;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.TextField;
import javafx.scene.layout.Pane;
import javafx.scene.shape.Line;
import org.json.simple.JSONObject;

import java.io.FileOutputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.net.URL;
import java.util.ResourceBundle;

public class VillageView_controller implements Initializable {
    @FXML public ChoiceBox NationList;
    @FXML public TextField VillageNameField;
    @FXML private Pane DrawingCanvas;

    @Override
    public void initialize(URL location, ResourceBundle resources) {

    }

    public void TreePressed(ActionEvent actionEvent){

        Line simpleLine = new Line(25,25,65,65);
        DrawingCanvas.getChildren().add(simpleLine);
        System.out.println(NationList.getValue());
        System.out.println(VillageNameField.getText());
    }

    public void SaveVillage() throws IOException {
        String FileName = VillageNameField.getText() + ".aov";
        JSONObject CurrentVillage = new JSONObject();
        CurrentVillage.put("villageName", VillageNameField.getText());
        CurrentVillage.put("nation", NationList.getValue());

        try {
            FileOutputStream file = new FileOutputStream("SavedFiles/"+FileName);
            ObjectOutputStream out = new ObjectOutputStream(file);
            out.writeObject(CurrentVillage.toJSONString());

        } catch (IOException e) {
            e.printStackTrace();
        }

    }

    public void save_village(ActionEvent actionEvent) throws IOException {
        SaveVillage();
        System.out.println("File Write done");
    }
}
