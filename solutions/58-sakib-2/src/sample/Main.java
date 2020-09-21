package sample;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;


public class Main extends Application {

    @Override
    public void start(Stage primaryStage) throws Exception{
        Parent xml=FXMLLoader.load(getClass().getResource("sample.fxml"));
        primaryStage.setTitle("Age of villagers");
        primaryStage.setScene(new Scene(xml,800,400));
        primaryStage.show();
    }


    public static void main(String[] args) {
        launch(args);
    }
}
