package main;

import canvas.MyCanvas;
import com.google.gson.Gson;
import house.IHouse;
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
import nation.NationManager;
import statemanager.CareTaker;
import statemanager.Originator;
import statemanager.State;
import statemanager.GameFile;
import terrain.ITerrain;
import tree.ITree;
import water.IWater;


public class Controller {
    Canvas canvas;
    NationManager nationManager;
    ITerrain iTerrain;
    IHouse house;
    ITree tree;
    IWater water;
    Originator originator = new Originator();
    CareTaker careTaker = new CareTaker();



    private String nation[] =
            {"Select Village Type","Bangladeshi Farmer", "Arab Bedouin", "Egyptian King", "Inuit Hunter","jhj"};

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

    String seletedV;



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

                seletedV = selectedVillage[0];

                System.out.println(selectedVillage[0]);
                treeRB.setVisible(true);
                houseRB.setVisible(true);
                waterRB.setVisible(true);
                houseRB.setSelected(false);
                treeRB.setSelected(false);
                waterRB.setSelected(false);
                saveVillageBTN.setVisible(true);

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

        house = nationManager.getHouse();
        house.draw(canvas,houseRB);

        originator.setState("home");
        careTaker.add(originator.saveStateToMemento());
        System.out.println("hooooooo");
    }
    @FXML
    void treeRBCon(ActionEvent actionEvent){
        houseRB.setSelected(false);
        treeRB.setSelected(true);
        waterRB.setSelected(false);

        tree = nationManager.getTree();
        tree.draw(canvas, treeRB);

        originator.setState("tree");
        careTaker.add(originator.saveStateToMemento());
        System.out.println("treeeeeeeee");
    }
    @FXML
    void waterRBCon(ActionEvent actionEvent){
        houseRB.setSelected(false);
        treeRB.setSelected(false);
        waterRB.setSelected(true);

        water = nationManager.getWater();
        water.draw(canvas, waterRB);

        originator.setState("water");
        careTaker.add(originator.saveStateToMemento());
        System.out.println("waaaaaaaaaa");
    }

    @FXML
    void saveVillageBTN(ActionEvent event) {


        State state = State.getInstance();
        System.out.println(state);

        GameFile gameFile= new GameFile(villageName.getText(), seletedV, state);

        Gson gson = new Gson();
        String json = gson.toJson(gameFile);

        System.out.println(json);

        GameFile gf = gson.fromJson(json,GameFile.class);

        System.out.println(gf);


//
//
//        System.out.println(json);

//        System.out.println("village saved");
//        FileChooser fileChooser = new FileChooser();
//        FileChooser.ExtensionFilter extensionFilter = new FileChooser.ExtensionFilter(".aov file", "*.aov");
//        fileChooser.getExtensionFilters().add(extensionFilter);
//        File file  = fileChooser.showSaveDialog(null);

    }

    @FXML
    void canvas(ActionEvent event) {
        System.out.println("canvas Clicked");

    }

}
