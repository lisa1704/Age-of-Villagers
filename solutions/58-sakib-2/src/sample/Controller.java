package sample;

import javafx.collections.FXCollections;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.*;


public class Controller {
    public RadioButton rbtnTree,rbtnHouse,rbtnWaterSource;
    public Button btnNewVillage,btnSaveVillage,btnOpenVillage;
    public TextField nameOfVillage;
    public ChoiceBox<String> nationOfVillage;
    public Label lblName,lblNation;
    public String[] st={"A","B","C"};
    public Canvas canvas;
    public boolean isCreating=true;

    public void selectTree(){
        rbtnHouse.setSelected(false);
        rbtnWaterSource.setSelected(false);
    }
    public void selectHouse(){
        rbtnTree.setSelected(false);
        rbtnWaterSource.setSelected(false);
    }
    public void selectWaterSource(){
        rbtnHouse.setSelected(false);
        rbtnTree.setSelected(false);
    }


    public void selectObject(){
        GraphicsContext gc =canvas.getGraphicsContext2D();
        if (rbtnTree.isSelected()){
            System.out.println("Tree is drawn");
        }
        else if (rbtnHouse.isSelected()){
            rbtnTree.setSelected(false);
            System.out.println("House is drawn");
        }
        else if (rbtnWaterSource.isSelected()){
            System.out.println("Water Source is drawn");

        }
    }
    public void newVillageLoader(){

        if (isCreating){
            nameOfVillage.setVisible(true);
            nationOfVillage.setItems(FXCollections.observableArrayList(st));
            nationOfVillage.setVisible(true);
            btnNewVillage.setText("Create Village");
            btnOpenVillage.setVisible(false);
            btnSaveVillage.setVisible(false);
            isCreating=false;
        }else{
            btnSaveVillage.setVisible(true);
            btnNewVillage.setVisible(false);
            lblName.setText(nameOfVillage.getText());
            lblNation.setText(nationOfVillage.getSelectionModel().getSelectedItem());
            nameOfVillage.setVisible(false);
            nationOfVillage.setVisible(false);
            isCreating=true;
        }

    }
    public void loadVillage(){}
    public void saveVillage(){
        btnOpenVillage.setVisible(true);
        btnNewVillage.setVisible(true);
        rbtnTree.setSelected(false);
        rbtnHouse.setSelected(false);
        rbtnWaterSource.setSelected(false);
        lblName.setText("Name");
        lblNation.setText("Nation");
    }
}
