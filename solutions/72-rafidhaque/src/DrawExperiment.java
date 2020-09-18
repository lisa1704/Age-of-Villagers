import javafx.application.Application;
import javafx.event.EventHandler;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.input.MouseEvent;
import javafx.scene.paint.Color;
import javafx.stage.Stage;

public class DrawExperiment extends Application {
    public DrawExperiment() {
    }

    @Override
    public void start(Stage primaryStage) throws Exception {
        Group root = new Group();

        int x1 = 200, y1 = 30, x2 = 300, y2 = 100;

        Rectangle rectangle = new Rectangle(root, x1, y1, x2, y2);
        Rectangle rectangle2 = new Rectangle(root, 230, 250, 10, 30);
        rectangle.draw();
        rectangle2.draw();


        Scene scene = new Scene(root, 400, 300, Color.AQUA);
        scene.setOnMouseClicked(new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent event) {
                onMousePressed(event);
            }
        });
        primaryStage.setScene(scene);
        primaryStage.show();
    }

    private void onMousePressed( MouseEvent mouseEvent ) {
        double x = mouseEvent.getX();
        double y = mouseEvent.getY();
        System.out.println(x+" "+y);
    }
}

