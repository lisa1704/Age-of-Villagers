package project.Controllers;

import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;

import javafx.scene.control.ComboBox;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.Pane;

import javafx.scene.shape.*;

import java.lang.String;


import java.net.URL;
import java.util.*;

import project.Utilities.NationFactory;
import project.Utilities.VillageState;
import project.Utilities.Villages;



public class VillageViewController implements Initializable {
    @FXML public ComboBox NationDropDown = new ComboBox();
    @FXML private TextField Village_Name;
    @FXML private Pane DrawPane;


    public NationFactory nationFactory;
    public String AssetType = "";
    public ArrayList<Shape> Object ;
    public Villages village;




    @Override
    public void initialize(URL location, ResourceBundle resources) {
        this.village = new Villages("FIRST INVOCATION!");
        NationDropDown.getItems().addAll(("Bangladeshi Farmers"),("Arab Bedouin"),("Egyptian Kings"),("Inuit Hunters"));
        DrawPane.setOnMouseClicked(new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent event) {
                if(AssetType == "Tree"){
                    Object = nationFactory.drawTree(event.getSceneX(),event.getSceneY());
                    village.assetList =village.AddAsset(event.getSceneX(), event.getSceneY(), AssetType);
                    DrawShape(Object);
                }
                else if(AssetType == "House"){
                    Object = nationFactory.drawHouse(event.getSceneX(),event.getSceneY());
                    village.assetList =village.AddAsset(event.getSceneX(), event.getSceneY(), AssetType);
                    DrawShape(Object);
                }
                else if(AssetType == "WaterSource"){
                    Object = nationFactory.drawWaterSource(event.getSceneX(),event.getSceneY());
                    village.assetList =village.AddAsset(event.getSceneX(), event.getSceneY(), AssetType);
                    DrawShape(Object);
//                    DrawPane.getChildren().clear();
                }
            }
        });
    }

    public void SaveVillage(ActionEvent actionEvent) {
        village.SaveVillage(this.village);
    }

    public void OpenVillage(ActionEvent actionEvent) {
        village = new Villages(Village_Name.getText());
        village = village.LoadVillage();
        Village_Name.setText(village.VillageName);

        DrawAssetList(village.assetList);

    }

    public void SelectTree(ActionEvent actionEvent) {
        this.AssetType = "Tree";
        System.out.println("TREE SELECTED!");
    }

    public void SelectHouse(ActionEvent actionEvent) {
        this.AssetType = "House";
        System.out.println("HOUSE SELECTED!");
    }

    public void SelectWaterSource(ActionEvent actionEvent) {
        this.AssetType = "WaterSource";
        System.out.println("WATERSOURCE SELECTED!");
    }

    public void DrawAssetList(ArrayList<VillageState> assetList){
        for ( VillageState a: assetList){
            if(a.AssetType.equals("Tree")){
                Object = nationFactory.drawTree(a.x,a.y);
                DrawShape(Object);
            }
            else if(a.AssetType.equals("House")){
                Object = nationFactory.drawHouse(a.x,a.y);
                DrawShape(Object);
            }
            else if(a.AssetType.equals("WaterSource")){
                Object = nationFactory.drawWaterSource(a.x,a.y);
                DrawShape(Object);
            }
        }
    }

    public void DrawShape(ArrayList<Shape> ShapeObject){
        for (Shape x : ShapeObject){
            DrawPane.getChildren().addAll(x);
        }
    }

    public void NationChanged(ActionEvent actionEvent) {
        DrawPane.getChildren().clear();
        nationFactory = new NationFactory((String) NationDropDown.getValue());
        DrawPane.setStyle("-fx-background-color:"+nationFactory.getTerrainColor((String) NationDropDown.getValue()));
        DrawAssetList(village.assetList);

    }

    public void createNewVillage(ActionEvent actionEvent) {
        DrawPane.getChildren().clear();
        this.village = new Villages(Village_Name.getText());
        DrawAssetList(village.assetList);


    }
}
