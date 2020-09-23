package sample;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;


public class ReadFile {
    public String data;
    File myObj;
    public ReadFile(File file){
        this.myObj=file;
    }
    public void read() {
        try {
            Scanner myReader = new Scanner(myObj);
            while (myReader.hasNextLine()) {
                data = myReader.nextLine();
                System.out.println(data);
            }
            myReader.close();
        } catch (FileNotFoundException e) {
            System.out.println("An error occurred.");
            e.printStackTrace();
        }
    }
    public String getVillageName(){
        int i=0;
        String name="";
        while (i<data.length()-4){
            if(data.charAt(i)=='N' && data.charAt(i+1)=='a' && data.charAt(i+2)=='m' && data.charAt(i+3)=='e'){
                int j=i+5;
                while (true){
                    if (data.charAt(j)==',')break;
                    name+=data.charAt(j);
                    j++;
                }
            }
            i++;
        }
        return name;
    }
}
