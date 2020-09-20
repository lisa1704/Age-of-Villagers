import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.stage.Stage;

public class Main extends Application {
    static Stage mainWindow;

    public static void main(String[] args) {
        launch(args);
    }

    void changeScene(Scene scene) {
        this.mainWindow.setScene(scene);
    }

    @Override
    public void start(Stage primaryStage) throws Exception {
        mainWindow = primaryStage;
        mainWindow.setTitle("Age of Villagers");

        Group g = new Group();
        INation bd = new ArabBedouin(g);

        ChoiceWindow choiceWindow = new ChoiceWindow();

        choiceWindow.getStage(choiceWindow.getDisplay()).show();


    }
}