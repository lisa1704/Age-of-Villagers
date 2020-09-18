package Project.Controllers;

import Project.Utilities.Village;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.ComboBox;
import javafx.scene.control.TextField;
import javafx.scene.layout.Pane;
import javafx.scene.shape.Line;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

import javax.swing.*;
import javax.swing.filechooser.FileSystemView;
import java.io.*;

import java.net.URL;
import java.util.ResourceBundle;

public class VillageView_controller implements Initializable {
    @FXML public TextField VillageNameField;
    @FXML public ComboBox NationList = new ComboBox();
    @FXML private Pane DrawingCanvas;

    @Override
    public void initialize(URL location, ResourceBundle resources) {
        NationList.getItems().addAll(("Bangladeshi Farmers"),("Arab Bedouins"),("Egyptian Kings"),("Inuit Hunters"));
    }

    public void TreePressed(ActionEvent actionEvent){

        Line simpleLine = new Line(25,25,65,65);
        DrawingCanvas.getChildren().add(simpleLine);
        System.out.println(NationList.getValue());
        System.out.println(VillageNameField.getText());
    }


    public void save_village(ActionEvent actionEvent) throws IOException {
        SaveVillage();
        System.out.println("File Write done");
    }


    public void Open_new_village(ActionEvent actionEvent) {
        File selectedFile = null;
        final JFrame iFRAME = new JFrame();
        iFRAME.setAlwaysOnTop(true);
        iFRAME.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        iFRAME.setLocationRelativeTo(null);
        iFRAME.requestFocus();

        JFileChooser fileChooser = new JFileChooser(FileSystemView.getFileSystemView());
        int returnValue = fileChooser.showOpenDialog(iFRAME);
        iFRAME.dispose();
        if (returnValue == JFileChooser.APPROVE_OPTION) {
            selectedFile = fileChooser.getSelectedFile();
            try {
                FileInputStream file = new FileInputStream(selectedFile.getAbsolutePath());
                ObjectInputStream in = new ObjectInputStream(file);
//                JSONObject obj = (JSONObject) in.readObject();
                Village village = (Village)in.readObject();

                System.out.println(village.Name+" of Nation "+ village.Nation);
            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        else {
            System.out.println("No File Selected");
        }
        System.out.println("File read done");
    }

    public void SaveVillage() throws IOException {
        String FileName = VillageNameField.getText() + ".aov";
        Village village = new Village(VillageNameField.getText(), (String) NationList.getValue());
        try {
            FileOutputStream file = new FileOutputStream("SavedFiles/"+FileName);
            ObjectOutputStream out = new ObjectOutputStream(file);
            out.writeObject(village);

        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}