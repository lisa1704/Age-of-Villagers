import javafx.geometry.Insets;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.Label;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;

public class ChoiceWindow {
    String boxValue;
    Scene scene;
    Stage stage;

    public String getBoxValue() {
        return boxValue;
    }

    public ChoiceWindow(Stage stage) {
        this.stage = stage;
    }

    public Stage display() {

        GridPane gridPane = new GridPane();
        gridPane.setPadding(new Insets(10, 10, 10, 10));

        Label chooseNation = new Label("Choose Nation");
        GridPane.setConstraints(chooseNation,2, 2);

        ChoiceBox<String> choiceBox = new ChoiceBox<>();
        choiceBox.getItems().add("Bangladeshi Farmers");
        choiceBox.getItems().add("Arab Bedouin");
        choiceBox.getItems().add("Egyptian Kings");
        choiceBox.getItems().add("Inuit Hunters");
        choiceBox.setValue("Bangladeshi Farmers");
        GridPane.setConstraints(choiceBox, 2, 4);

        Button newVillage = new Button("New Village");
        Button openVillage = new Button("Open Village");

        GridPane.setConstraints(newVillage, 2, 10);
        GridPane.setConstraints(openVillage, 3, 10);
        GridPane.setMargin(newVillage, new Insets(50, 0, 0, 0));
        GridPane.setMargin(openVillage, new Insets(50, 0, 0, 0));
        GridPane.setMargin(choiceBox, new Insets(10, 0, 0, 0));


        newVillage.setOnAction(event -> {
            scene = getChoice(choiceBox);
            stage.setScene(scene);
        });



        gridPane.getChildren().addAll(chooseNation, choiceBox, newVillage, openVillage);
        scene = new Scene(gridPane, 400, 250);
        stage.setScene(scene);
        return stage;
    }

    private Scene getChoice(ChoiceBox<String> choiceBox) {
        String nation = choiceBox.getValue();

        Group g = new Group();
        INation nation1 = null;

        if (nation.equals("Bangladeshi Farmers")) {
            nation1 = new BangladeshiFarmers(g);
        } else if (nation.equals("Arab Bedouin")) {
            nation1 = new ArabBedouin(g);
        } else if (nation.equals("Egyptian Kings")) {
            nation1 = new EgyptianKings(g);
        } else if (nation.equals("Inuit Hunters")) {
            nation1 = new InuitHunters(g);
        }

        ShowWindow showWindow = new ShowWindow(nation1, g);

        System.out.println(nation);
        return showWindow.display();
    }

}
