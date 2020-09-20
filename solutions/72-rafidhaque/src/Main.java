import javafx.application.Application;
import javafx.scene.Group;
import javafx.stage.Stage;

public class Main extends Application {

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage primaryStage) throws Exception {

        Group g = new Group();
        INation bd = new BangladeshiFarmers(g);

        ShowWindow controlPanel = new ShowWindow();

        controlPanel.start(primaryStage);
    }
}