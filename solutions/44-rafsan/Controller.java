package sample;

import javafx.collections.FXCollections;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.canvas.Canvas;
import javafx.scene.control.*;
import javafx.scene.layout.AnchorPane;
import javafx.stage.FileChooser;


import java.io.File;


public class Controller {
    @FXML
    private RadioButton tree;

    @FXML
    private RadioButton house;

    @FXML
    private RadioButton waterSource;


    @FXML
    private AnchorPane drawingSpace;

    @FXML
    private AnchorPane infoLayout;

    @FXML
    private TextField inputVillageName;

    @FXML
    private ComboBox<String> inputNationName;

    private String nation[] =
            {"Bangladeshi Farmers", "Arab Bedouin", "Egyptian Kings", "Inuit Hunters"};

    @FXML
    private Button createVillage;


    @FXML
    private Label villageName;

    @FXML
    private Label nationName;

    @FXML
    private AnchorPane openLayout;

    @FXML
    private ComboBox<String> inputNationNameForOpen;

    @FXML
    private Button openVillageButton;

    private CurrentState currentState = CurrentState.getInstance();

    private Canvas canvas;
    private NationManager nationManager;
    private ITree iTree;
    private IHouse iHouse;
    private IWaterSource iWaterSource;
    private ITerrain iTerrain;

   


    @FXML
    void createVillage(ActionEvent event) {
        villageName.setText(inputVillageName.getText());
        nationName.setText(inputNationName.getValue());
        currentState.setVillageName(inputVillageName.getText());
        infoLayout.setVisible(false);
        initialize();
    }

    private void initialize() {
        CanvasSingleton canvasSingleton = CanvasSingleton.getInstance();
        canvas = canvasSingleton.getCanvas();
        drawingSpace.getChildren().add(canvas);

        nationManager = new NationManager(inputNationName.getValue());
        iTerrain = nationManager.getTerrain();
        iTerrain.draw();
    }


    @FXML
    void newVillage(ActionEvent event) {
        inputNationName.setItems(FXCollections.observableArrayList(nation));
        infoLayout.setVisible(true);
    }













    @FXML
    void selectHouse(ActionEvent event) {
        if (house.isSelected()) {
            iHouse = nationManager.getHouse();
            iHouse.getCanvas();
            iHouse.canvasController();
        } else {
            iHouse.releaseCanvas();
        }
    }

    @FXML
    void selectTree(ActionEvent event) {
        if (tree.isSelected()) {
            iTree = nationManager.getTree();
            iTree.getCanvas();
            iTree.canvasController();
        } else {
            iTree.releaseCanvas();
        }
    }


    @FXML
    void selectWaterSource(ActionEvent event) {
        if (waterSource.isSelected()) {
            iWaterSource = nationManager.getWaterSource();
            iWaterSource.getCanvas();
            iWaterSource.canvasControlle();
        } else {
            iWaterSource.releaseCanvas();
        }
    }
}