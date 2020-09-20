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

    public ShowWindow(INation nation, Group drawSpace) {
        this.nation = nation;
        this.drawSpace = drawSpace;
        house = this.nation.getHouse();
        tree = this.nation.getTree();
        water = this.nation.getWater();
        gridOfControls = new GridOfControls(house, tree, water, this.nation.getNationName());
    }

    public MouseClickManager mouseClickManager = new MouseClickManager();


    public void setNation(INation nation) {

    }

    StateOfComponent stateOfComponent = null;
    ArrayList<StateOfComponent> stateOfComponents = new ArrayList<StateOfComponent>();

//    InuitHunters inuitHunters = new InuitHunters(drawSpace);
//    BangladeshiFarmers bangladeshiFarmers = new BangladeshiFarmers(drawSpace);
//    EgyptianKings egyptianKings = new EgyptianKings(drawSpace);
//    ArabBedouin arabBedouin = new ArabBedouin(drawSpace);


    public void setDrawSpace(Group drawSpace) {
        this.drawSpace = drawSpace;
    }

    public Scene getDisplay() {

        Rectangle rectangle2 = new Rectangle(drawSpace, 0, 0, 600, 400);
        rectangle2.draw();

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
                stateOfComponent = mouseClickManager.onMousePressed(event, gridOfControls.getNowDrawing());
                stateOfComponents.add(stateOfComponent);
            }
        });

        gridOfControls.newButton.setOnAction(event -> {

            ChoiceWindow choiceWindow = new ChoiceWindow();
            Main.mainWindow.setScene(choiceWindow.getDisplay());

            drawSpace.getChildren().clear();
            stateOfComponents.clear();
            Rectangle newRectangle = new Rectangle(drawSpace, 0, 0, 600, 400);
            newRectangle.draw();
        });

        return scene;
    }


    @Override
    public Stage getStage(Scene scene) {
        Main.mainWindow.setScene(scene);
        return Main.mainWindow;
    }
}
