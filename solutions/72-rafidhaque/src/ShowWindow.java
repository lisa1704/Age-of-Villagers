import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import javafx.event.EventHandler;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;

import java.util.ArrayList;

public class ShowWindow implements IWindow{

    Group drawSpace;
    INation nation;
    DrawHouse house;
    DrawTree tree;
    DrawWater water;
    GridOfControls gridOfControls;
    ArrayList<StateOfComponent> stateOfComponents;

    public ShowWindow(INation nation, Group drawSpace, ArrayList<StateOfComponent> arrayList) {
        this.nation = nation;
        this.drawSpace = drawSpace;
        house = this.nation.getHouse();
        tree = this.nation.getTree();
        water = this.nation.getWater();
        gridOfControls = new GridOfControls(house, tree, water, this.nation.getNationName());
        this.stateOfComponents = arrayList;
    }

    public MouseClickManager mouseClickManager = new MouseClickManager();

    public void setDrawSpace(Group drawSpace) {
        this.drawSpace = drawSpace;
    }

    public Scene getDisplay() {

        Rectangle rectangle2 = new Rectangle( 0, 0, 600, 400);
        drawSpace.getChildren().addAll(rectangle2.draw());

        GridPane gridPane = gridOfControls.createGrid();

        BorderPane layout = new BorderPane();
        layout.setRight(gridPane);
        layout.setLeft(drawSpace);
        layout.setMaxSize(800,400);
        layout.setMinSize(800,400);


        Scene scene = new Scene(layout, 800, 400);

        scene.setOnMouseClicked(new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent event) {
                StateOfComponent stateOfComponent = mouseClickManager.onMousePressed(drawSpace, event, gridOfControls.getNowDrawing());
                stateOfComponents.add(stateOfComponent);
            }
        });

        gridOfControls.newButton.setOnAction(event -> {
            ChoiceWindow choiceWindow = new ChoiceWindow();
            Main.mainWindow.setScene(choiceWindow.getDisplay());
        });

        gridOfControls.saveButton.setOnAction(event -> {
            GsonBuilder builder = new GsonBuilder();
            builder.setPrettyPrinting();

            Gson gson = builder.create();

            String newJsonString = gson.toJson(this.stateOfComponents);
            System.out.println(newJsonString);
        });

        return scene;
    }


    @Override
    public Stage getStage(Scene scene) {
        Main.mainWindow.setScene(scene);
        return Main.mainWindow;
    }
}
