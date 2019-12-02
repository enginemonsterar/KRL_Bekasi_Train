using System;

[Serializable]
public class Deadman
{
    public bool Pressed;
        
    public Deadman(bool pressed){
        this.Pressed = pressed;        
    }
    public Deadman(){
        
    }    
}
