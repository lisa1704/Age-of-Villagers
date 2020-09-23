import javafx.event.EventHandler;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.GridPane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;
import javafx.scene.shape.Shape;
import javafx.stage.FileChooser;
import javafx.stage.Stage;

import java.io.*;
import java.util.ArrayList;

public class ShowWindow implements IWindow{

    String villageName;
    Group drawSpace;
    INation nation;
    DrawHouse house;
    DrawTree tree;
    DrawWater water;
    GridOfControls gridOfControls;
    ArrayList<StateOfComponent> stateOfComponents;

    public ShowWindow(INation nation, String villageName, Group drawSpace, ArrayList<StateOfComponent> arrayList) {
        this.nation = nation;
        this.villageName = villageName;
        this.drawSpace = drawSpace;
        house = this.nation.getHouse();
        tree = this.nation.getTree();
        water = this.nation.getWater();
        gridOfControls = new GridOfControls(house, tree, water, this.nation.getNationName(), this.villageName);
        this.stateOfComponents = arrayList;
    }

    public MouseClickManager mouseClickManager = new MouseClickManager();

    public void setDrawSpace(Group drawSpace) {
        this.drawSpace = drawSpace;
    }

    public Scene getDisplay() {

        Rctangle rectangle2 = new Rctangle( 0, 0, 600, 400);
        drawSpace.getChildren().addAll(rectangle2.draw());

        GridPane gridPane = gridOfControls.createGrid();

        BorderPane layout = new BorderPane();
        layout.setRight(gridPane);
        layout.setLeft(drawSpace);
        layout.setMaxSize(800,400);
        layout.setMinSize(800,400);


        Scene scene = new Scene(layout, 800, 400);

        scene.setOnMouseClicked(new EventHandler<MouseEvent>() {
            @Override
            public void handle(MouseEvent event) {
                if (mouseRestriction(event.getX(), event.getY())) {
                    StateOfComponent stateOfComponent = mouseClickManager.onMousePressed(drawSpace, event, gridOfControls.getNowDrawing());
                    stateOfComponents.add(stateOfComponent);
                }
            }
        });

        gridOfControls.newButton.setOnAction(event -> {
            ChoiceWindow choiceWindow = new ChoiceWindow();
            Starter.mainWindow.setScene(choiceWindow.getDisplay());
        });

        gridOfControls.saveButton.setOnAction(event -> {
            // java serialize

            FileOutputStream fileOutputStream = null;
            try {
                fileOutputStream = new FileOutputStream("./"+this.villageName+".aov");
                ObjectOutputStream out = new ObjectOutputStream(fileOutputStream);
                out.writeObject(this.stateOfComponents);
                out.close();
                fileOutputStream.close();
                System.out.println("Data saved");
            } catch (FileNotFoundException e) {
                e.printStackTrace();
            } catch (IOException e) {
                e.printStackTrace();
            }

            // java deserialize

            ArrayList<StateOfComponent> stateOfComponents10 = null;
            try {
                FileInputStream fileIn = new FileInputStream("./"+this.villageName+".aov");
                ObjectInputStream in = new ObjectInputStream(fileIn);
                stateOfComponents10 = (ArrayList<StateOfComponent>) in.readObject();
                in.close();
                fileIn.close();
            } catch (Exception e1) {
                e1.printStackTrace();
            }

            System.out.println("Rafidd");
            System.out.println(stateOfComponents10.get(1));

        });

        gridOfControls.openButton.setOnAction(event -> {

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

            Rectangle rectangle = new Rectangle(0,0, 600,400);

            System.out.println(stateOfComponents10.get(0));

            if (stateOfComponents10.get(0).toString().startsWith("Arab")) {
                rectangle.setFill(Color.LIGHTYELLOW);
            } else if (stateOfComponents10.get(0).toString().startsWith("Bangladesh")) {
                rectangle.setFill(Color.GREENYELLOW);
            } else if (stateOfComponents10.get(0).toString().startsWith("Egypt")) {
                rectangle.setFill(Color.LIGHTYELLOW);
            } else if (stateOfComponents10.get(0).toString().startsWith("Inuit")) {
                rectangle.setFill(Color.WHITE);
            } else {
                rectangle.setFill(Color.GRAY);
            }
            drawSpace.getChildren().addAll(rectangle);


            int sizee = stateOfComponents10.size();

            for (int k = 0; k < sizee; k++) {
                ArrayList<Shape> drawing = stateOfComponents10.get(k).drawComponent.draw(stateOfComponents10.get(k).getX(), stateOfComponents10.get(k).getY());
                drawSpace.getChildren().addAll(drawing);
            }
        });

        return scene;
    }


    boolean mouseRestriction(double x, double y) {
        if (x + 24 <= 600 && y + 24 <= 400) {
            return true;
        }
        return false;
    }

    @Override
    public Stage getStage(Scene scene) {
        Starter.mainWindow.setScene(scene);
        return Starter.mainWindow;
    }
}

