import javafx.application.Application;
import javafx.geometry.Insets;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.ComboBox;
import javafx.scene.control.Label;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;

public class ChoiceWindow extends Application {
    Stage window;

    @Override
    public void start(Stage primaryStage) throws Exception {
        window = primaryStage;

        GridPane gridPane = new GridPane();
        gridPane.setPadding(new Insets(10, 10, 10, 10));

        Label chooseNation = new Label("Choose Nation");
        GridPane.setConstraints(chooseNation,2, 2);

        ComboBox comboBox = new ComboBox();
        comboBox.getItems().add("Bangladeshi Farmers");
        comboBox.getItems().add("Arab Bedouin");
        comboBox.getItems().add("Egyptian Kings");
        comboBox.getItems().add("Inuit Hunters");
        GridPane.setConstraints(comboBox, 2, 4);

        Button newVillage = new Button("New Village");
        Button openVillage = new Button("Open Village");

        GridPane.setConstraints(newVillage, 2, 10);
        GridPane.setConstraints(openVillage, 3, 10);
        GridPane.setMargin(newVillage, new Insets(50, 0, 0, 0));
        GridPane.setMargin(openVillage, new Insets(50, 0, 0, 0));
        GridPane.setMargin(comboBox, new Insets(10, 0, 0, 0));

        String boxValue = (String) comboBox.getValue();

        if (boxValue.equals("Bangladeshi Farmers")) {

        } else if (boxValue.equals("Arab Bedouin")) {

        } else if (boxValue.equals("Egyptian Kings")) {

        } else if (boxValue.equals("Inuit Hunters")) {

        }

        gridPane.getChildren().addAll(chooseNation, comboBox, newVillage, openVillage);
        Scene scene = new Scene(gridPane, 400, 250);
        window.setScene(scene);
        window.show();
    }
}
