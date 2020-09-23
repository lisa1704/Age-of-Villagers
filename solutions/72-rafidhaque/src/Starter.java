import javafx.application.Application;
import javafx.stage.Stage;

public class Starter extends Application {
    static Stage mainWindow;

    @Override
    public void start(Stage primaryStage) throws Exception {
        mainWindow = primaryStage;
        mainWindow.setTitle("Age of Villagers");

        ChoiceWindow choiceWindow = new ChoiceWindow();

        choiceWindow.getStage(choiceWindow.getDisplay()).show();


    }
}