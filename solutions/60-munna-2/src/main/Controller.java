package main;

import house.BangladeshiFarmersHouse;
import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.canvas.Canvas;
import javafx.scene.control.*;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.Pane;
import javafx.stage.Stage;
import nations.BangladeshiFarmer;
import tree.BangladeshiFarmersTree;
import waterSource.Pond;

import java.io.IOException;
import java.net.URL;
import java.util.ResourceBundle;

public class Controller implements Initializable {

    @FXML
    private ToggleGroup toggleGroup;

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
    private Canvas drawing_space_canvas;

    public static Canvas d1,d2,d3;


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
    private BangladeshiFarmer bangladeshiFarmer;
    private BangladeshiFarmersHouse bangladeshiFarmersHouse;
    private BangladeshiFarmersTree bangladeshiFarmersTree;
    private Pond pond;
    private Canvas canvas;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        cn_label = country_name;
        vn_label = village_name;
        toggleGroup = new ToggleGroup();
        bangladeshiFarmer = new BangladeshiFarmer();
        bangladeshiFarmersHouse = new BangladeshiFarmersHouse();
        bangladeshiFarmersTree = new BangladeshiFarmersTree();
        pond = new Pond();
        MainCanvas mainCanvas = MainCanvas.getInstance();
        canvas = mainCanvas.getCanvas();
        drawing_space.getChildren().add(canvas);
    }

    public void RadioSelect(ActionEvent actionEvent)
    {
        if (house_RadioButton.isSelected())
        {
            bangladeshiFarmersHouse.Draw();
            bangladeshiFarmersHouse.draw_house();
            bangladeshiFarmersTree.Dont_Draw();
            pond.Dont_Draw();
        }
        else if (tree_RadioButton.isSelected())
        {
            bangladeshiFarmersTree.Draw();
            bangladeshiFarmersTree.draw_Tree();
            bangladeshiFarmersHouse.Dont_Draw();
            pond.Dont_Draw();
        }
        else if(water_RadioButton.isSelected())
        {
            pond.Draw();
            pond.draw_water_resource();
            bangladeshiFarmersHouse.Dont_Draw();
            bangladeshiFarmersTree.Dont_Draw();
        }

    }

    /*@FXML
    public void House_Button_Clicked (ActionEvent event){
        if (house_RadioButton.isSelected()) {
            bangladeshiFarmersHouse.Draw();
            bangladeshiFarmersHouse.draw_house();
            bangladeshiFarmersHouse.Dont_Draw();
        }
        else {
            bangladeshiFarmersHouse.Dont_Draw();
        }
    }

    @FXML
    void Tree_Button_Clicked (ActionEvent event){
        if (tree_RadioButton.isSelected()) {
            bangladeshiFarmersTree.Draw();
            bangladeshiFarmersTree.draw_Tree();
        }
        else {
            bangladeshiFarmersTree.Dont_Draw();
        }
    }

    @FXML
    void WaterSource_Button_Clicked (ActionEvent event){
        if (water_RadioButton.isSelected()) {
            pond.Draw();
            pond.draw_water_resource();
        }
        else {
            pond.Dont_Draw();
        }
    }*/

}


