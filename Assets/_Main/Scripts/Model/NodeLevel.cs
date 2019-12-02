using System;

[Serializable]
public class NodeLevel
{
    public int Level;
    public string Name;
    

    public NodeLevel(int level){
        this.Level = level;
        this.Name = IntNodeToStringNode(level);        
    }

    public NodeLevel(){
        
    }

    private string IntNodeToStringNode(int level){
        switch (level)
        {
            case 0: 
                return "N";
            case 1: 
                return "P1";
            case 2: 
                return "P2";
            case 3: 
                return "P3";
            case 4: 
                return "P4";
            case -1: 
                return "B1";
            case -2: 
                return "B2";
            case -3: 
                return "B3";
            case -4: 
                return "B6";
            case -5: 
                return "EM";
            default:
                return "N";
        }
    }
    
}
