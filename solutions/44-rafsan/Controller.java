package sample;
import javafx.scene.control.Button;

import javafx.fxml.FXML;
import javafx.scene.canvas.Canvas;
import javafx.scene.control.*;
import javafx.event.ActionEvent;

import java.io.File;
public class Controller {

    private CurrentState currentState = CurrentState.getInstance();

    private Canvas canvas;
    private NationManager nationManager;
    private IHouse iHouse;
    @FXML
    private RadioButton house;

    @FXML
    void selectHouse(ActionEvent event) {
        if (house.isSelected()) {
            iHouse = nationManager.getHouse();
            iHouse.getCanvas();
            iHouse.canvasController();
        } else {
            iHouse.releaseCanvas();
        }
    }
}
