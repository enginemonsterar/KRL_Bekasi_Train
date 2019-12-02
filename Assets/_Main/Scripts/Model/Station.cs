using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class Station 
{
    public string Id;
    public string Name;
    public float PositionTime_0;
    public float PositionTime_1;

    public Station(string id, string name, float PositionTime_0, float PositionTime_1){
        this.Id = id;
        this.Name = name;
        this.PositionTime_0 = PositionTime_0;
        this.PositionTime_1 = PositionTime_1;
    }
    
}
