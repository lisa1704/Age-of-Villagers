import javafx.application.Application;
import javafx.scene.Group;
import javafx.stage.Stage;

public class Main extends Application {
    Stage window;

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage primaryStage) throws Exception {
        window = primaryStage;

        Group g = new Group();
        INation bd = new ArabBedouin(g);

        ShowWindow controlPanel = new ShowWindow(bd, g);

        window.setScene(controlPanel.display());
        window.show();
    }
}