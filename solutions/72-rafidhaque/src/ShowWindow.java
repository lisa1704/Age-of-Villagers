import javafx.application.Application;
import javafx.event.EventHandler;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;

import java.util.ArrayList;

public class ShowWindow extends Application {
    public Stage window;
//    public ShowWindow(INation nation) {
//        this.nation = nation;
//    }

    public MouseClickManager mouseClickManager = new MouseClickManager();

    Group drawSpace = new Group();
    INation nation = new BangladeshiFarmers(drawSpace);

    StateOfComponent stateOfComponent = null;
    ArrayList<StateOfComponent> stateOfComponents = new ArrayList<StateOfComponent>();

    InuitHunters inuitHunters = new InuitHunters(drawSpace);
    BangladeshiFarmers bangladeshiFarmers = new BangladeshiFarmers(drawSpace);
    EgyptianKings egyptianKings = new EgyptianKings(drawSpace);
    ArabBedouin arabBedouin = new ArabBedouin(drawSpace);

    DrawHouse house = this.nation.getHouse();
    DrawTree tree = this.nation.getTree();
    DrawWater water = this.nation.getWater();
    public GridOfControls gridOfControls = new GridOfControls(house, tree, water, this.nation.getNationName());

    public void setDrawSpace(Group drawSpace) {
        this.drawSpace = drawSpace;
    }

    @Override
    public void start(Stage primaryStage) throws Exception {
        window = primaryStage;
        window.setTitle("Age of Villagers");

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
            drawSpace.getChildren().clear();
            stateOfComponents.clear();
            Rectangle newRectangle = new Rectangle(drawSpace, 0, 0, 600, 400);
            newRectangle.draw();
        });

        window.setScene(scene);
        window.show();
    }
}
