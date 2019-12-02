using System;

[Serializable]
public class DoorStatus
{
    public bool Opened;
        
    public DoorStatus(bool opened){
        this.Opened = opened;        
    }
    public DoorStatus(){
        
    }    
}
