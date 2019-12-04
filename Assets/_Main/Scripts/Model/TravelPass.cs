using System;

[Serializable]
public class TravelPass 
{
    public string Id;
    public bool Active;
    public string MachinistId;
    public string TrainRouteId;
    public string LogHistoryId;

    public TravelPass(string id, bool active, string machinistId, string trainRouteId, string logHistoryId){
        this.Id = id;
        this.Active = active;
        this.MachinistId = machinistId;
        this.TrainRouteId = trainRouteId;
        this.LogHistoryId = logHistoryId;
    }

    public TravelPass(){
        
    }
    
}
