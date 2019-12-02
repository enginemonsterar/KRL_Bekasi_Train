using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using System;

[Serializable]
public class TrainRoute 
{
    public string Id;
    public string Name;
    public Machinist Machinist;
    public Station[] Stations;
    public RouteSignal RouteSignal;
    public string VideoClipName;

    public TrainRoute(string id, string name, Machinist machinist, Station[] stations, RouteSignal routeSignal, string videoClipName){
        this.Id = id;
        this.Name = name;
        this.Machinist = machinist;
        this.Stations = stations;
        this.RouteSignal = routeSignal;
        this.VideoClipName = videoClipName;
    }

    


}
