package Project.Utilities;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonElement;
import com.google.gson.JsonParser;

import javax.swing.*;
import javax.swing.filechooser.FileSystemView;
import java.io.*;

public class VillageSaverLoader {

    SceneSate sceneSate = null;

    public void saveVillage(SceneSate sceneSate){
        String FileName = sceneSate.Village_name + ".aov";

        Gson gson = new Gson();
        String json = gson.toJson(sceneSate);

        try {
            File jsonFile = new File("SavedFiles/"+FileName);
            FileWriter writer = new FileWriter(jsonFile);
            writer.write(json);
            writer.close();
            System.out.println("successfully saved!");

        } catch (IOException e) {
            e.printStackTrace();
        }

    }

    public SceneSate loadVillage(){
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
            try{
                BufferedReader bufferedReader = new BufferedReader(new FileReader(selectedFile));
                sceneSate = new Gson().fromJson(bufferedReader,SceneSate.class);
            }catch (Exception e) {
                e.printStackTrace();
            }
        }
        else {
            System.out.println("No File Selected!");
        }
        return sceneSate;

    }
}
