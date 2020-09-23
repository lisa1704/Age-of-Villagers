package project.Utilities;

import com.google.gson.Gson;


import javax.swing.*;
import javax.swing.filechooser.FileSystemView;
import java.io.*;
import java.util.ArrayList;

public class Villages {
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
        Gson gson = new Gson();
        String json = gson.toJson(village);
        try {

            File jsonFile = new File("SavedVillages/"+Filename);
            FileWriter writer = new FileWriter(jsonFile);
            writer.write(json);
            writer.close();
            System.out.println(Filename+" Successfully saved!");
    } catch (Exception e) {
        e.printStackTrace();
    }

    }

    public Villages LoadVillage(){
        Villages villages = null;
        File selectedFile = this.selectFileFromPopup();
        if(selectedFile != null)
        {
            try {
                BufferedReader br = new BufferedReader(new FileReader(selectedFile));
                villages = new Gson().fromJson(br,Villages.class);
                System.out.println("File loaded Successfully!");

            } catch (Exception e) {
                e.printStackTrace();
                System.out.println("FILE SELECTION ERROR!");
            }

        }
        else{
            System.out.println("FILE NOT SELECTED!");
        }
        return  villages;
    }

    public File selectFileFromPopup(){
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
        }
        else {
            System.out.println("No File Selected!");
        }
        return selectedFile;

    }
}
