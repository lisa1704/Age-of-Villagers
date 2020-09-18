import javafx.application.Application;
import javafx.geometry.Insets;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.ColumnConstraints;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.RowConstraints;
import javafx.scene.text.Font;
import javafx.stage.Stage;

public class ControlPanel extends Application {
    public Stage window;

    @Override
    public void start(Stage primaryStage) throws Exception {
        window = primaryStage;
        window.setTitle("Age of Villagers");

        GridPane gridPane = new GridPane();
        gridPane.setGridLinesVisible( false );
        for (int i = 0; i < 2; i++) {
            ColumnConstraints column = new ColumnConstraints(100);
            gridPane.getColumnConstraints().add(column);
        }

        RowConstraints row1 = new RowConstraints(50);
        gridPane.getRowConstraints().add(row1);

        gridPane.setPadding(new Insets(10, 10, 10 ,10));
        gridPane.setVgap(8);
        gridPane.setHgap(10);

        Label gameName = new Label("Age of Villagers");
        gameName.setFont(new Font(20.0));
        Label villageName = new Label("Bangladesh");
        Label nationName = new Label("Bangladeshi");

        Button treeButton = new Button("Tree");
        Button houseButton = new Button("House");
        Button waterSourceButton = new Button("Water Source");

        Button saveButton = new Button("Save");
        Button newButton = new Button("New");
        Button openButton = new Button(" Open");

        GridPane.setConstraints(gameName, 0, 0, 2, 1);
        GridPane.setConstraints(villageName, 0, 1);
        GridPane.setConstraints(nationName, 0, 2);

        GridPane.setConstraints(treeButton, 0, 8);
        GridPane.setConstraints(houseButton, 0, 8);
        GridPane.setMargin(houseButton, new Insets(0, 0, 0, 50));
        GridPane.setConstraints(waterSourceButton, 0, 9);
        waterSourceButton.setMaxSize(Double.MAX_VALUE, Double.MAX_VALUE);

        GridPane.setConstraints(saveButton, 0, 13);
        saveButton.setMaxSize(Double.MAX_VALUE, Double.MAX_VALUE);
        GridPane.setConstraints(newButton, 0, 14);
        GridPane.setConstraints(openButton, 0, 14);
        GridPane.setMargin(openButton, new Insets(0, 0, 0, 50));

        gridPane.getChildren().addAll(gameName, villageName, nationName, treeButton, houseButton, waterSourceButton, saveButton, newButton, openButton);


        // Group Draw space

        Group drawSpace = new Group();

        gridPane.setMaxSize(200,400);
        gridPane.setMinSize(200,400);


        BorderPane layout = new BorderPane();
        layout.setRight(gridPane);
        layout.setLeft(drawSpace);
        layout.setMaxSize(800,400);
        layout.setMinSize(800,400);


        Scene scene = new Scene(layout, 800, 400);
        window.setScene(scene);
        window.show();
    }
}
