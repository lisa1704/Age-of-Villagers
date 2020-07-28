package project;

public class Dog {
    private int marker;

    public Dog(int marker){
        this.marker = marker;
    }

    public String bark(){
        if(marker == 1){
            return "GHEU!";
        }
        else{
            return "VOU!";
        }
    }
}
