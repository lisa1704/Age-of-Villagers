package Village;

import javafx.geometry.Insets;
import javafx.geometry.Pos;
import javafx.scene.control.RadioButton;
import javafx.scene.control.Button;
import javafx.scene.layout.*;
import javafx.scene.canvas.*;
import javafx.scene.paint.Color;


public class VillageView extends VBox {
    private Canvas canvas;
    private Button saveVillage,openVillage,newVillage;
    private RadioButton tree,house,waterSource;

    public VillageView() {
        this.canvas = new Canvas(600,400);
        this.saveVillage = new Button("Save Village");
        this.openVillage = new Button("Open Village");
        this.newVillage = new Button("New Village");
        this.tree=new RadioButton("Tree");
        this.house=new RadioButton("House");
        this.waterSource=new RadioButton("Water source");
        this.getChildren().addAll(tree,house,waterSource,saveVillage,openVillage,newVillage);
    }
}
