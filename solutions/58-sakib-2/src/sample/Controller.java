package sample;

import javafx.collections.FXCollections;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.*;
import javafx.scene.input.MouseButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane;
import java.io.FileWriter;
import java.io.IOException;


public class Controller {
    public RadioButton rbtnTree,rbtnHouse,rbtnWaterSource;
    public Button btnNewVillage,btnSaveVillage,btnOpenVillage;
    public TextField nameOfVillage;
    public ChoiceBox<String> nationOfVillage;
    public Label lblName,lblNation;
    public String[] st={"A","B","C"};
    public boolean isCreating=true;
    public AnchorPane drawSpace;
    public Canvas canvas;
    public GraphicsContext gc;
    public FileWriter fileWriter=null;

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


    public String selectObject(){


        if (rbtnTree.isSelected()){
            //System.out.println("Tree is drawn");
            return "Tree";
        }
        else if (rbtnHouse.isSelected()){
            //System.out.println("House is drawn");
            return "House";
        }
        else if (rbtnWaterSource.isSelected()){
            //System.out.println("Water Source is drawn");
            return "WS";
        }
        return null;

    }
    public void getPositionAndObject(){
        if (rbtnTree.isSelected() || rbtnHouse.isSelected() || rbtnWaterSource.isSelected()){
            canvas.setOnMouseClicked(new EventHandler<MouseEvent>() {
                @Override
                public void handle(MouseEvent event) {
                    String object=selectObject();
                    if (event.getButton().equals(MouseButton.PRIMARY)){
                        if (event.getClickCount()==2){
                            double x,y;
                            x=event.getX();
                            y=event.getY();
                            gc=canvas.getGraphicsContext2D();
                            try {
                                fileWriter.write(object+" "+x+" "+y+"\n");
                            } catch (IOException e) {
                                e.printStackTrace();
                            }
                            if (object=="Tree")gc.fillText("T",x,y);
                            else if (object=="House")gc.fillText("H",x,y);
                            else if (object=="WS")gc.fillText("W",x,y);
                        }
                    }

                }
            });
        }
        else{
            System.out.println("Select any object to draw.");
        }

    }
    public void initialState(){
        rbtnTree.setVisible(false);
        rbtnHouse.setVisible(false);
        rbtnWaterSource.setVisible(false);
        btnSaveVillage.setVisible(false);
        lblName.setText("Name");
        lblNation.setText("Nation");
        btnOpenVillage.setVisible(true);
        btnNewVillage.setVisible(true);
        drawSpace.getChildren().removeAll(canvas);
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
            if (nameOfVillage.getText().equals("") || nationOfVillage.getSelectionModel().isEmpty()){
                System.out.println("Give all information!");
            }else{try{
                fileWriter=new FileWriter("D:\\5th Semester\\DP\\age-of-villagers-swe-17\\solutions\\58-sakib-2\\"+nameOfVillage.getText()+".txt",true);
                fileWriter.write(nameOfVillage.getText()+" "+nationOfVillage.getSelectionModel().getSelectedItem()+"\n");
            }catch (Exception e){

            }
                rbtnTree.setVisible(true);
                rbtnHouse.setVisible(true);
                rbtnWaterSource.setVisible(true);
                btnSaveVillage.setVisible(true);
                btnNewVillage.setVisible(false);
                lblName.setText(nameOfVillage.getText());
                lblNation.setText(nationOfVillage.getSelectionModel().getSelectedItem());
                nameOfVillage.setVisible(false);
                nationOfVillage.setVisible(false);
                isCreating=true;
            }

        }

    }
    public void loadVillage(){}
    public void saveVillage(){
        try {
            fileWriter.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
        initialState();
    }
}
