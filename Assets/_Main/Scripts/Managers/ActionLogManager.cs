using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using MonsterAR.Network;
using MonsterAR.Utility;
using System;
public class ActionLogManager : Singleton<ActionLogManager>
{
    private List<ActionLog> actionLogs;
    private List<TravelPass> travelPasses;
    private string filePath;
    private string filePathTravelPass;
    public void WriteActionLog(string name, string value){
            
        LoadData();
        LoadDataTravelPass();
                
        ActionLog actionLog = new ActionLog(travelPasses[0].LogHistoryId, name, value, DateTime.Now);
        
        //Add new ActionLog to list
        this.actionLogs.Add(actionLog);
        
        //Write ActionLog list to json object
        string jsonData = JsonHelper.ToJson(this.actionLogs.ToArray(), true);
        File.WriteAllText(filePath, jsonData);  

        PlayerSendData.Instance.SendActionLog(actionLog);      
    }
    void Awake(){
        filePath = Application.dataPath  + "/_Main" + "/Scripts" + "/JSON" + "/ActionLog.json";
        filePathTravelPass = Application.dataPath  + "/_Main" + "/Scripts" + "/JSON" + "/TravelPass.json";
    }

    public void LoadData(){
        //Read All ActionLog from json
        string jsonFile = File.ReadAllText(filePath);        
        //Convert json object to ActionLog class object
        ActionLog[] actions_ = JsonHelper.FromJson<ActionLog>(jsonFile);   
        //Convert array to list
        actionLogs = new List<ActionLog>(actions_);
    }
    public void LoadDataTravelPass(){
        //Read All TravelPass from json
        string jsonFile = File.ReadAllText(filePathTravelPass);        
        //Convert json object to TravelPass class object
        TravelPass[] travelPasses_ = JsonHelper.FromJson<TravelPass>(jsonFile);   
        //Convert array to list
        travelPasses = new List<TravelPass>(travelPasses_);
    }
}
