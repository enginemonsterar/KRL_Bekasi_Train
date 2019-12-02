using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using MonsterAR.Utility;

[System.Serializable]
public class TrainRouteManager : Singleton<TrainRouteManager>
{
    // Start is called before the first frame update
    void Start()
    {
        
        string jsonFile = File.ReadAllText(Application.dataPath  + "/_Main" + "/Scripts" + "/JSON" + "/TrainRoute.json");        
        TrainRoute[] trainRoutes = JsonHelper.FromJson<TrainRoute>(jsonFile);   
        // Debug.Log("Train Routes Lenght: " + trainRoutes.Length);
        // Debug.Log("Machinist Name: " + trainRoutes[0].Machinist.Name);
        // Debug.Log("Station Lenght: " + trainRoutes[0].Stations.Length);
        // for (int i = 0; i < trainRoutes[0].Stations.Length; i++)
        // {            
        //     Debug.Log("Station " + i + " Name: " + trainRoutes[0].Stations[i].Name);
        // }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
