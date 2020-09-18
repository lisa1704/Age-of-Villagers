import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.paint.Color;
import javafx.scene.shape.Line;
import javafx.stage.Stage;

public class DrawExperiment extends Application {
    @Override
    public void start(Stage primaryStage) throws Exception {
        Group root = new Group();

        Line line = new Line(200, 30, 400, 30);

        root.getChildren().addAll(line);


        Scene scene = new Scene(root, 400, 300, Color.AQUA);
        primaryStage.setScene(scene);
        primaryStage.show();
    }
}
