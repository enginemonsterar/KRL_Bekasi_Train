using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class Signal 
{
    public string Id;
    public string Name;
    public string Description;
    public string SpriteName;

    public Signal(string id, string name, string description, string spriteName){
        this.Id = id;
        this.Name = name;
        this.Description = description;        
        this.SpriteName = spriteName;
    }
    
}
