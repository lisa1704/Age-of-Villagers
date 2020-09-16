package main;

import canvas.MyCanvas;
import javafx.beans.value.ChangeListener;
import javafx.beans.value.ObservableValue;
import javafx.collections.FXCollections;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.canvas.Canvas;
import javafx.scene.control.Button;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.RadioButton;
import javafx.scene.control.TextField;
import javafx.scene.layout.AnchorPane;
import nation.BDFarmers;
import nation.NationManager;
import terrain.BDFarmerTerrain;
import terrain.ITerrain;

import java.util.List;

public class Controller {
    Canvas canvas;
    ITerrain iTerrain;
    NationManager nationManager;

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



    private void initialize() {
    }


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

        villageTypeList.getSelectionModel().selectedIndexProperty().addListener(new ChangeListener<Number>() {
            @Override
            public void changed(ObservableValue<? extends Number> observableValue, Number number, Number t1) {
                selectedVillage[0] = nation[Integer.parseInt(observableValue.getValue().toString())];

                System.out.println(selectedVillage[0]);


                System.out.println("village selected");
                treeRB.setVisible(true);
                houseRB.setVisible(true);
                waterRB.setVisible(true);
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
    void saveVillageBTN(ActionEvent event) {
        System.out.println("village saved");
    }

    @FXML
    void canvas(ActionEvent event) {
        System.out.println("canvas Clicked");
    }

}
