import javafx.scene.Scene;
import javafx.stage.Stage;

public interface IWindow {
    Scene getDisplay();
    Stage getStage(Scene scene);
}
