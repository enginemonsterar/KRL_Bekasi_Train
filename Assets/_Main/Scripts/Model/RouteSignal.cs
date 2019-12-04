using System.Collections;
using System.Collections.Generic;
using System;

[Serializable]
public class RouteSignal 
{
    public string Id;    
    public string[] SignalIds;
    public int[] ActiveTimeInSeconds;
    public int[] DeactiveTimeInSeconds;

    public RouteSignal (string id, string[] signalIds, int[] activeTimeInSeconds, int[] deactiveTimeInSeconds){
        this.Id = id;
        this.SignalIds = signalIds;
        this.ActiveTimeInSeconds = activeTimeInSeconds;
        this.DeactiveTimeInSeconds = deactiveTimeInSeconds;
    }
    public RouteSignal (){

    }
    
}
