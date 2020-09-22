package Project.Controllers;
import Project.Utilities.*;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.ComboBox;
import javafx.scene.control.TextField;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.Pane;
import javafx.scene.shape.*;
import java.net.URL;
import java.util.ArrayList;
import java.util.ResourceBundle;

public class VillageView_controller implements Initializable {
    @FXML public TextField VillageNameField;
    @FXML public ComboBox NationList = new ComboBox();
    @FXML private Pane DrawingCanvas;
    public String flag;
    public Nation nation;
    public SceneSate sceneSate;
    private String villageName = "MY village";
    VillageSaverLoader SLD;

    @Override
    public void initialize(URL location, ResourceBundle resources) {
        NationList.getItems().addAll(("Bangladeshi Farmers"),("Arab Bedouins"),("Egyptian Kings"),("Inuit Hunters"));
        nation = new Nation("No Nation");
        SLD = new VillageSaverLoader();
        sceneSate = new SceneSate(villageName);
        VillageNameField.setText(villageName);
        DrawingCanvas.setOnMouseClicked(new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent event) {
                sceneSate.add_asset_to_list(flag,event.getSceneX(),event.getSceneY());
                reDrawScene();
            }
        });
    }


    public void save_village(ActionEvent actionEvent){
        SLD.saveVillage(sceneSate);
    }


    public void Open_new_village(ActionEvent actionEvent) {
        SceneSate tempState = SLD.loadVillage();
        if(!tempState.equals(null)){
            this.sceneSate = tempState;
            this.villageName = sceneSate.Village_name;
        }
        reDrawScene();
    }

    public void TreePressed(ActionEvent actionEvent){ flag = "Tree"; }

    public void HousePressed(ActionEvent actionEvent) { flag = "House"; }

    public void WaterPressed(ActionEvent actionEvent) { flag = "WaterSource"; }
    
    public void DrawShape(ArrayList<Shape> shape_to_be_drawn){
        for (Shape s:shape_to_be_drawn) {
            DrawingCanvas.getChildren().addAll(s);
        }
    }

    public void ChangeNation(ActionEvent actionEvent) {
        nation = new Nation((String) NationList.getValue());
        DrawingCanvas.setStyle("-fx-background-color:"+nation.GetTerrainColor());
        reDrawScene();
    }

    public void CreateNewVillage(ActionEvent actionEvent) {
        sceneSate = new SceneSate(VillageNameField.getText());
        DrawingCanvas.getChildren().clear();
    }

    private void reDrawScene(){
        VillageNameField.setText(sceneSate.Village_name);
        DrawingCanvas.getChildren().clear();
        for(AssetInfo i:sceneSate.assetList){
            if(i.assetType.equals("Tree")){
                ArrayList<Shape> tree = nation.drawTree(i.x_coordinate,i.y_coordinate);
                DrawShape(tree);
            }
            else if (i.assetType.equals("House")){
                ArrayList<Shape> house = nation.drawHouse(i.x_coordinate,i.y_coordinate);
                DrawShape(house);
            }
            else if(i.assetType.equals("WaterSource")){
                ArrayList<Shape> WaterBody = nation.drawWaterBody(i.x_coordinate,i.y_coordinate);
                DrawShape(WaterBody);
            }
        }
    }
}