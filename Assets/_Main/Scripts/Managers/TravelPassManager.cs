using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using MonsterAR.Utility;

public class TravelPassManager : Singleton<TravelPassManager>
{
    private List<TravelPass> travelPasses;
    private List<Machinist> machinists;
    private List<Station> stations;
    private List<TrainRoute> trainRoutes;
    private string filePathTravelPass;
    private string filePathMachinist;
    private string filePathStation;
    private string filePathTrainRoute;
    public GameObject travelPassForm;
    public InputField idIF;
    public InputField machinistIF;
    public InputField trainRouteIF;
    public Text startStationText;
    public Text finishStationText;

    

    void Awake(){
        filePathTravelPass = Application.dataPath  + "/_Main" + "/Scripts" + "/JSON" + "/TravelPass.json";
        filePathMachinist = Application.dataPath  + "/_Main" + "/Scripts" + "/JSON" + "/Machinist.json";
        filePathStation = Application.dataPath  + "/_Main" + "/Scripts" + "/JSON" + "/Station.json";
        filePathTrainRoute = Application.dataPath  + "/_Main" + "/Scripts" + "/JSON" + "/TrainRoute.json";
    }


    public void SetupTravelPass(TravelPass travelPass){
        LoadDataMachinist();
        LoadDataTrainRoute();
        LoadDataStation();

        //Reset TravelPass
        LoadDataTravelPass();
        for (int i = 0; i < travelPasses.Count; i++)
        {            
            travelPasses.RemoveAt(i);
        }
 
        this.travelPasses.Add(travelPass);
        
        //Write TravelPass list to json object
        string jsonData = JsonHelper.ToJson(this.travelPasses.ToArray(), true);
        File.WriteAllText(filePathTravelPass, jsonData); 
        LoadDataTravelPass();
        Debug.Log("Travel Pass LogHistoryId: " + travelPasses[0].LogHistoryId);
       
        travelPassForm.SetActive(true);
        idIF.text = travelPass.Id;

        //Find Machinist
        Machinist machinist = new Machinist();
        for (int i = 0; i < machinists.Count; i++)
        {
            if(machinists[i].Id == travelPass.MachinistId){
                machinist = machinists[i];
                
            }
        }

        //Find Train Route
        TrainRoute trainRoute = new TrainRoute();
        for (int i = 0; i < trainRoutes.Count; i++)
        {
                         
            if(trainRoutes[i].Id == travelPass.TrainRouteId){
                trainRoute = trainRoutes[i];                    
            }
            
        }
        machinistIF.text = machinist.Name;
        trainRouteIF.text = trainRoute.Name ;
        
    }

   

    public void LoadDataTravelPass(){
        //Read All TravelPass from json
        string jsonFile = File.ReadAllText(filePathTravelPass);                
        //Convert json object to TravelPass class object
        TravelPass[] travelPass_ = JsonHelper.FromJson<TravelPass>(jsonFile);   
        //Convert array to list
        travelPasses = new List<TravelPass>(travelPass_);
    }

    public void LoadDataMachinist(){
        //Read All Machinist from json
        string jsonFile = File.ReadAllText(filePathMachinist);        
        //Convert json object to Machinist class object
        Machinist[] machinist_ = JsonHelper.FromJson<Machinist>(jsonFile);   
        //Convert array to list
        machinists = new List<Machinist>(machinist_);
    }

    public void LoadDataStation(){
        //Read All Station from json
        string jsonFile = File.ReadAllText(filePathStation);        
        //Convert json object to Station class object
        Station[] station_ = JsonHelper.FromJson<Station>(jsonFile);   
        //Convert array to list
        stations = new List<Station>(station_);
    }

    public void LoadDataTrainRoute(){
        //Read All TrainRoute from json
        string jsonFile = File.ReadAllText(filePathTrainRoute);        
        //Convert json object to TrainRoute class object
        TrainRoute[] trainRoute_ = JsonHelper.FromJson<TrainRoute>(jsonFile);   
        //Convert array to list
        trainRoutes = new List<TrainRoute>(trainRoute_);
    }
}
