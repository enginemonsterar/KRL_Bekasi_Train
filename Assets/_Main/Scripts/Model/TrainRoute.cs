using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using System;

[Serializable]
public class TrainRoute 
{
    public string Id;
    public string Name;
    public string[] StationIds;
    public string RouteSignalId;
    // public string VideoClipName;

    public TrainRoute(string id, string name, string[] stationIds, string routeSignalId){
        this.Id = id;
        this.Name = name;        
        this.StationIds = stationIds;
        this.RouteSignalId = routeSignalId;
        // this.VideoClipName = videoClipName;
    }

    public TrainRoute(){
        
    }
}
