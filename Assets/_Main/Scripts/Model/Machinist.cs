using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class Machinist 
{
    public string Id;
    public string Name;

    public Machinist(string id, string name){
        this.Id = id;
        this.Name = name;
    }

    public Machinist(){
        
    }
    
}
