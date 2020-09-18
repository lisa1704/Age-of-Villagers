import javafx.application.Application;
import javafx.stage.Stage;

public class Main extends Application {
    ControlPanel controlPanel = new ControlPanel();

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage primaryStage) throws Exception {
        controlPanel.start(primaryStage);
    }
}
