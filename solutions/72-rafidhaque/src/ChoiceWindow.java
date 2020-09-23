import javafx.geometry.Insets;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.ChoiceBox;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.layout.GridPane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;
import javafx.scene.shape.Shape;
import javafx.stage.FileChooser;
import javafx.stage.Stage;

import java.io.File;
import java.io.FileInputStream;
import java.io.ObjectInputStream;
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
        Button openVillage = new Button("Open Village");

        Label orLabel = new Label("  or:  ");

        GridPane.setConstraints(villageName, 2, 9);
        GridPane.setConstraints(newVillage, 2, 10);
        GridPane.setConstraints(orLabel, 3, 10);
        GridPane.setConstraints(openVillage, 4, 10);
        GridPane.setMargin(villageName, new Insets(50, 0, 0, 0));
        GridPane.setMargin(choiceBox, new Insets(10, 0, 0, 0));


        newVillage.setOnAction(event -> {
            village = villageName.getText();
            if (village.length() > 0) {
                scene = getChoice(choiceBox, village);
                Starter.mainWindow.setScene(scene);
            }
        });

        openVillage.setOnAction(event -> {
            Scene scene= openVillage(choiceBox);
            Starter.mainWindow.setScene(scene);
        });

        gridPane.getChildren().addAll(chooseNation, choiceBox, newVillage, villageName, openVillage, orLabel);
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

    private Scene openVillage(ChoiceBox<String> choiceBox) {
        FileChooser fileChooser = new FileChooser();
        File selectedFile = fileChooser.showOpenDialog(Starter.mainWindow);
        String filePath = selectedFile.getAbsolutePath();

        ArrayList<StateOfComponent> stateOfComponents10 = null;

        try {
            FileInputStream fileIn = new FileInputStream(filePath);
            ObjectInputStream in = new ObjectInputStream(fileIn);
            stateOfComponents10 = (ArrayList<StateOfComponent>) in.readObject();
            in.close();
            fileIn.close();
        } catch (Exception e1) {
            e1.printStackTrace();
        }

        Group drawSpace = new Group();
        Rectangle rectangle = new Rectangle(0,0, 600,400);

        System.out.println(stateOfComponents10.get(0));

        if (stateOfComponents10.get(0).className.startsWith("Arab")) {
            rectangle.setFill(Color.LIGHTYELLOW);
        } else if (stateOfComponents10.get(0).className.startsWith("Bangladesh")) {
            rectangle.setFill(Color.GREENYELLOW);
        } else if (stateOfComponents10.get(0).className.startsWith("Egypt")) {
            rectangle.setFill(Color.LIGHTYELLOW);
        } else if (stateOfComponents10.get(0).className.startsWith("Inuit")) {
            rectangle.setFill(Color.WHITE);
        } else {
            rectangle.setFill(Color.GRAY);
        }

        String nation = choiceBox.getValue();
        INation nation1 = null;

        if (nation.equals("Bangladeshi Farmers")) {
            nation1 = new BangladeshiFarmers(drawSpace);
        } else if (nation.equals("Arab Bedouin")) {
            nation1 = new ArabBedouin(drawSpace);
        } else if (nation.equals("Egyptian Kings")) {
            nation1 = new EgyptianKings(drawSpace);
        } else if (nation.equals("Inuit Hunters")) {
            nation1 = new InuitHunters(drawSpace);
        }


        village = selectedFile.getName();
        village = removeLastChars(village, 4);

        ShowWindow showWindow = new ShowWindow(nation1, village, drawSpace, stateOfComponents10);


        drawSpace.getChildren().addAll(rectangle);

        int sizee = stateOfComponents10.size();

        for (int k = 0; k < sizee; k++) {
            ArrayList<Shape> drawing = stateOfComponents10.get(k).drawComponent.draw(stateOfComponents10.get(k).getX(), stateOfComponents10.get(k).getY());
            drawSpace.getChildren().addAll(drawing);
        }

        return showWindow.getDisplay();
    }

    public static String removeLastChars(String str, int chars) {
        return str.substring(0, str.length() - chars);
    }


}
