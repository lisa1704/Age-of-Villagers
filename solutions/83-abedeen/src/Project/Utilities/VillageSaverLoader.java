package Project.Utilities;

import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import com.google.gson.JsonElement;
import com.google.gson.JsonParser;

import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;

public class VillageSaverLoader {
    public void saveVillage(SceneSate sceneSate){
        String FileName = sceneSate.Village_name + ".aov";

        Gson gson = new Gson();
        String json = gson.toJson(sceneSate);

        Gson gson1 = new GsonBuilder().setPrettyPrinting().create();
        JsonElement je = new JsonParser().parse(json);
        System.out.println(gson1.toJson(je));
        try {
            FileOutputStream file = new FileOutputStream("SavedFiles/"+FileName);
            ObjectOutputStream out = new ObjectOutputStream(file);
            out.writeObject(json);

        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public void loadVillage(){

    }
}
