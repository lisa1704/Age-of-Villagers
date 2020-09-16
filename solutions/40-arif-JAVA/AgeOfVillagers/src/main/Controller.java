package main;

import canvas.MyCanvas;
import house.IHouse;
import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.collections.FXCollections;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.Button;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.RadioButton;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane;
import javafx.scene.shape.ArcType;
import javafx.stage.FileChooser;
import nation.BDFarmers;
import nation.NationManager;
import terrain.BDFarmerTerrain;
import terrain.ITerrain;

import java.io.File;
import java.util.List;

public class Controller {
    Canvas canvas;
    NationManager nationManager;
    ITerrain iTerrain;
    IHouse house;



    private String nation[] =
            {"Select Village Type","Bangladeshi Farmer", "Arab Bedouin", "Egyptian King", "Inuit Hunter"};

    @FXML
    private Button newVillageBTN;
    @FXML
    private Button openVillageBTN;
    @FXML
    private Button saveVillageBTN;


    @FXML
    private TextField villageName;
    @FXML
    private ChoiceBox villageTypeList;
    @FXML
    private RadioButton houseRB;
    @FXML
    private RadioButton treeRB;
    @FXML
    private RadioButton waterRB;

    @FXML
    private AnchorPane terrain;



    @FXML
    void newVillageBTN(ActionEvent event) {
        System.out.println("New Village Request");
        final String[] selectedVillage = {nation[0]};
        newVillageBTN.setDisable(true);
        openVillageBTN.setVisible(false);
        villageName.setVisible(true);
        villageTypeList.setVisible(true);

        villageTypeList.setItems(FXCollections.observableArrayList(nation));
        villageTypeList.setValue(nation[0]);

        MyCanvas myCanvas = MyCanvas.getInstance();
        canvas = myCanvas.getCanvas();

        GraphicsContext graphicsContext = canvas.getGraphicsContext2D();
        canvas.addEventHandler(MouseEvent.MOUSE_PRESSED, new EventHandler<javafx.scene.input.MouseEvent>() {

            @Override
            public void handle(MouseEvent mouseEvent) {
                graphicsContext.strokeArc(mouseEvent.getX(), mouseEvent.getY(),50,50,200,360, ArcType.OPEN);
            }
        });

        villageTypeList.getSelectionModel().selectedIndexProperty().addListener(new ChangeListener<Number>() {
            @Override
            public void changed(ObservableValue<? extends Number> observableValue, Number number, Number t1) {
                selectedVillage[0] = nation[Integer.parseInt(observableValue.getValue().toString())];

                System.out.println(selectedVillage[0]);
                treeRB.setVisible(true);
                houseRB.setVisible(true);
                waterRB.setVisible(true);
                houseRB.setSelected(true);
                treeRB.setSelected(false);
                waterRB.setSelected(false);
                saveVillageBTN.setVisible(true);

                houseRB.setSelected(true);

                terrain.getChildren().clear();
                terrain.getChildren().add(canvas);
                nationManager = new NationManager(selectedVillage[0]);
                iTerrain = nationManager.getTerrain();
                if (iTerrain != null)
                    iTerrain.draw();
            }
        });
    }

    @FXML
    void houseRBCon(ActionEvent actionEvent){
        houseRB.setSelected(true);
        treeRB.setSelected(false);
        waterRB.setSelected(false);

//        house = nationManager.getHouse();
//        house.draw();
    }
    @FXML
    void treeRBCon(ActionEvent actionEvent){
        houseRB.setSelected(false);
        treeRB.setSelected(true);
        waterRB.setSelected(false);
    }
    @FXML
    void waterRBCon(ActionEvent actionEvent){
        houseRB.setSelected(false);
        treeRB.setSelected(false);
        waterRB.setSelected(true);
    }

    @FXML
    void saveVillageBTN(ActionEvent event) {
        System.out.println("village saved");
        FileChooser fileChooser = new FileChooser();
        FileChooser.ExtensionFilter extensionFilter = new FileChooser.ExtensionFilter(".aov file", "*.aov");
        fileChooser.getExtensionFilters().add(extensionFilter);
        File file  = fileChooser.showSaveDialog(null);

    }

    @FXML
    void canvas(ActionEvent event) {
        System.out.println("canvas Clicked");

    }

}
