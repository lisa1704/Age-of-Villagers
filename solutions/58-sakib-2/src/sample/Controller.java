package sample;

import Factory.NationFactory;
import Nations.INation;
import javafx.collections.FXCollections;
import javafx.event.EventHandler;
import javafx.scene.canvas.Canvas;
import javafx.scene.canvas.GraphicsContext;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.control.*;
import javafx.scene.input.MouseButton;
import javafx.scene.input.MouseEvent;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.Background;
import javafx.scene.layout.BackgroundFill;
import javafx.stage.FileChooser;

import java.awt.*;
import java.io.File;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.Dictionary;
import java.util.Hashtable;


public class Controller {
    public RadioButton rbtnTree,rbtnHouse,rbtnWaterSource;
    public Button btnNewVillage,btnSaveVillage,btnOpenVillage;
    public TextField nameOfVillage;
    public ChoiceBox<String> nationOfVillage;
    public Label lblName,lblNation;
    public String[] st={"Bangladeshi Farmers","Arab Bedouin","Egyptian Kings","Inuit Hunters"};
    public boolean isCreating=true;
    public AnchorPane drawSpace;
    public Canvas canvas;
    public GraphicsContext gc;
    public Dictionary dictionary;
    public ArrayList<Point> treeList;
    public ArrayList<Point> houseList;
    public ArrayList<Point> wsList;
    public NationFactory nationFactory;
    public INation nation;

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
                            int x,y;
                            x=(int)event.getX();
                            y=(int)event.getY();
                            Point point=new Point(x,y);
                            gc=canvas.getGraphicsContext2D();
                            if (object=="Tree"){
                                nation.getTree().draw(canvas,point);
                                treeList.add(point);
                            }

                            else if (object=="House"){
                                nation.getHouse().draw(canvas,point);
                            }
                            else if (object=="WS"){
                                gc.fillText("W",x,y);
                                wsList.add(new Point(x,y));
                            }
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
            }else{
                nationFactory=new NationFactory();
                nation=nationFactory.getNation(nationOfVillage.getSelectionModel().getSelectedItem());
                BackgroundFill backgroundFill = nation.getTerrain().getTerrain();
                Background background=new Background(backgroundFill);
                drawSpace.setBackground(background);

                dictionary=new Hashtable();
                treeList=new ArrayList<Point>();
                houseList=new ArrayList<Point>();
                wsList=new ArrayList<Point>();
                dictionary.put("Name",nameOfVillage.getText());
                dictionary.put("Nation",nationOfVillage.getSelectionModel().getSelectedItem());
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
    public void loadVillage(){

    }
    public void saveVillage(){
        dictionary.put("Tree",treeList);
        dictionary.put("House",houseList);
        dictionary.put("WS",wsList);
        FileChooser fileChooser = new FileChooser();

        FileChooser.ExtensionFilter extFilter = new FileChooser.ExtensionFilter("Text format (*.txt)", "*.txt");
        fileChooser.getExtensionFilters().add(extFilter);

        File file = fileChooser.showSaveDialog(null);

        if (file != null) {
            try {
                PrintWriter writer;
                writer = new PrintWriter(file);
                writer.println(dictionary);
                writer.close();
            } catch (IOException ex) {

            }

        }
        initialState();
    }
}
