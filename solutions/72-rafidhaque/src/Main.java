import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.stage.Stage;

public class Main extends Application {
    Stage window;

    public static void main(String[] args) {
        launch(args);
    }

    void changeScene(Scene scene) {
        this.window.setScene(scene);
    }

    @Override
    public void start(Stage primaryStage) throws Exception {
        window = primaryStage;

        Group g = new Group();
        INation bd = new ArabBedouin(g);

        ChoiceWindow choiceWindow = new ChoiceWindow(window);

        choiceWindow.display().show();


    }
}