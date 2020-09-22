package Project.Utilities;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonElement;
import com.google.gson.JsonParser;

import java.io.*;

public class VillageSaverLoader {

    SceneSate sceneSate = null;

    public void saveVillage(SceneSate sceneSate){
        String FileName = sceneSate.Village_name + ".aov";

        Gson gson = new Gson();
        String json = gson.toJson(sceneSate);

        Gson gson1 = new GsonBuilder().setPrettyPrinting().create();
        JsonElement je = new JsonParser().parse(json);
        System.out.println(gson1.toJson(je));
        try {
            File jsonFile = new File("SavedFiles/"+FileName);
            FileWriter writer = new FileWriter(jsonFile);
            writer.write(json);
            writer.close();

        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public SceneSate loadVillage(){
        try{
            BufferedReader bufferedReader = new BufferedReader(new FileReader("SavedFiles/try.aov"));
            sceneSate = new Gson().fromJson(bufferedReader,SceneSate.class);
        }catch (Exception e) {
            e.printStackTrace();
        }
        return sceneSate;

    }
}
