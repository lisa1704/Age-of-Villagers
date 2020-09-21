import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import javafx.scene.Group;

import java.util.ArrayList;

public class TestingGson {
    public static void main(String[] args) {
        ArrayList<StateOfComponent> stateOfComponents = new ArrayList<>();

        Group g = new Group();

        IDrawComponent newIDrawComponent = new ArabBedouinHouse(g);
        StateOfComponent stateOfComponent1 = new StateOfComponent(1,2, newIDrawComponent);
        StateOfComponent stateOfComponent2 = new StateOfComponent(1,2, newIDrawComponent);
        StateOfComponent stateOfComponent3 = new StateOfComponent(1,2, newIDrawComponent);

        stateOfComponents.add(stateOfComponent1);
        stateOfComponents.add(stateOfComponent2);
        stateOfComponents.add(stateOfComponent3);

        GsonBuilder builder = new GsonBuilder();
        builder.setPrettyPrinting();

        Gson gson = builder.create();

        String newJsonString = gson.toJson(g);
        System.out.println(newJsonString);
    }
}
