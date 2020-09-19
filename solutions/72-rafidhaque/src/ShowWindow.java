import javafx.application.Application;
import javafx.event.EventHandler;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;

public class ShowWindow extends Application {
    public Stage window;
    public IDrawComponent nowDrawing;
    public MouseClickManager mouseClickManager = new MouseClickManager();
    Group drawSpace = new Group();
    DrawHouse house = new DrawHouse(drawSpace);
    DrawTree tree = new DrawTree(drawSpace);
    DrawWater water = new DrawWater(drawSpace);
    public GridOfControls gridOfControls = new GridOfControls(house, tree, water);

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
                mouseClickManager.onMousePressed(event, gridOfControls.getNowDrawing());
            }
        });

        gridOfControls.newButton.setOnAction(event -> {
            Group newDrawSpace = new Group();
            layout.setLeft(newDrawSpace);
            Rectangle newRectange = new Rectangle(newDrawSpace, 0, 0, 600, 400);
            newRectange.draw();
        });

        window.setScene(scene);
        window.show();
    }
}
