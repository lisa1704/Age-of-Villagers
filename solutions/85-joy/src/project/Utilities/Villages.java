package project.Utilities;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonElement;
import com.google.gson.JsonParser;

import javax.swing.*;
import javax.swing.filechooser.FileSystemView;
import java.io.*;
import java.util.ArrayList;

public class Villages implements Serializable {
    public String VillageName;
    public ArrayList<VillageState> assetList;

    public Villages(String Name){
        this.VillageName = Name;
        assetList = new ArrayList<VillageState>();
    }

    public ArrayList<VillageState> AddAsset(double x, double y , String AssetType){
        VillageState currentState = new VillageState(x,y,AssetType);
        this.assetList.add(currentState);
        return assetList;
    }

    public void SaveVillage(Villages village){
        String Filename = village.VillageName + ".aov";
////        JSONObject obj = new JSONObject();
////        obj.put("Village_Name",Village_Name.getText());
////        obj.put("Nation",NationDropDown.getValue());
////        Villages villages = new Villages(Village_Name.getText(), (String) NationDropDown.getValue());
//        try {
//            FileOutputStream file = new FileOutputStream("SavedVillages/"+Filename);
//            ObjectOutputStream out = new ObjectOutputStream(file);
////            out.writeObject(villages);
//        } catch (Exception e) {
//            e.printStackTrace();
//        }
        Gson gson = new Gson();
        String json = gson.toJson(village);

        Gson gson1 = new GsonBuilder().setPrettyPrinting().create();
        JsonElement je = new JsonParser().parse(json);
        System.out.println(gson1.toJson(je));
        try {
//            FileOutputStream file = new FileOutputStream("SavedVillages/"+Filename);
//            ObjectOutputStream out = new ObjectOutputStream(file);
//            out.writeObject(json);
            File jsonFile = new File("SavedVillages/"+Filename);
            FileWriter writer = new FileWriter(jsonFile);
            writer.write(json);
            writer.close();
    } catch (Exception e) {
        e.printStackTrace();
    }

    }

    public Villages LoadVillage(){
        Villages villages = null;
        File selectedFile = null;
        final JFrame iFRAME = new JFrame();
        iFRAME.setAlwaysOnTop(true);
        iFRAME.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        iFRAME.setLocationRelativeTo(null);
        iFRAME.requestFocus();

        JFileChooser fileChooser = new JFileChooser(FileSystemView.getFileSystemView());
        int returnValue = fileChooser.showOpenDialog(iFRAME);
        iFRAME.dispose();
        if (returnValue == JFileChooser.APPROVE_OPTION) {
            selectedFile = fileChooser.getSelectedFile();
            try {
                BufferedReader br = new BufferedReader(new FileReader(selectedFile));
                villages = new Gson().fromJson(br,Villages.class);

            } catch (Exception e) {
                e.printStackTrace();
            }
        }
        else {
            System.out.println("No File Selected!");
        }


        return  villages;

    }
}
