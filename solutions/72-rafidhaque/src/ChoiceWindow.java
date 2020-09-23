import javafx.geometry.Insets;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.GridPane;
import javafx.stage.Stage;

import java.util.ArrayList;

public class ChoiceWindow implements IWindow {
    String boxValue;
    Scene scene;
    String village;

    public String getBoxValue() {
        return boxValue;
    }


    public Scene getDisplay() {

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

        TextField villageName = new TextField();
        villageName.setPromptText("New Village Name");

        Button newVillage = new Button("New Village");

        GridPane.setConstraints(villageName, 2, 9);
        GridPane.setConstraints(newVillage, 2, 10);
        GridPane.setMargin(villageName, new Insets(50, 0, 0, 0));
        GridPane.setMargin(choiceBox, new Insets(10, 0, 0, 0));


        newVillage.setOnAction(event -> {
            village = villageName.getText();
            if (village.length() > 0) {
                scene = getChoice(choiceBox, village);
                Starter.mainWindow.setScene(scene);
            }
        });



        gridPane.getChildren().addAll(chooseNation, choiceBox, newVillage, villageName);
        scene = new Scene(gridPane, 400, 250);
        return scene;
    }

    @Override
    public Stage getStage(Scene scene) {
        Starter.mainWindow.setScene(scene);
        return Starter.mainWindow;
    }

    private Scene getChoice(ChoiceBox<String> choiceBox, String village) {
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

        ShowWindow showWindow = new ShowWindow(nation1, village, g, new ArrayList<StateOfComponent>());

        System.out.println(nation);
        return showWindow.getDisplay();
    }

}
