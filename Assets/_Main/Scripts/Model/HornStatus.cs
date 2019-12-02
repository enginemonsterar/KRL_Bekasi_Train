using System;

[Serializable]
public class HornStatus
{
    public bool Active;
        
    public HornStatus(bool active){
        this.Active = active;        
    }
    public HornStatus(){
        
    }    
}
