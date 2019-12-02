using System;

[Serializable]
public class ClutchMode
{
    public int Mode;
    public string Name;
    

    public ClutchMode(string name){
        this.Name = name;        
        this.Mode = StringToIntMode(name);
    }

    public ClutchMode(){
        
    }

    private int StringToIntMode(string name){
        switch (name)
        {
            case "netral": 
                return 0;
            case "front": 
                return 1;
            case "back": 
                return -1;            
            default:
                return 99;
        }
    }
    
}
