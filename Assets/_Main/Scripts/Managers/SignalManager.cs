using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SignalManager : MonoBehaviour
{
    [SerializeField] private Image signalImage;
    
    private List<RouteSignal> routeSignals;
    private List<Signal> signals = new List<Signal>();
    private string filePathRouteSignal;
    private string filePathSignal;

    private bool signalActive;
    private int signalOrder = 0;
    
    void Awake(){
        filePathSignal = Application.dataPath  + "/_Main" + "/Scripts" + "/JSON" + "/Signal.json";   
        filePathRouteSignal = Application.dataPath  + "/_Main" + "/Scripts" + "/JSON" + "/RouteSignal.json";
    }

    void Start(){
        LoadDataRouteSignal();
        LoadDataSignal();
    }

    void Update() {
        
        if(VideoSpeedManager.Instance.GetVideoTime() >= routeSignals[0].ActiveTimeInSeconds[signalOrder]){
            signalImage.enabled = true;
            signalActive = true;            
            string path = "Sprites/" + FindSignal(routeSignals[0].SignalIds[signalOrder]).SpriteName;
<<<<<<< HEAD
            signalImage.sprite = Resources.Load<Sprite>(path);            
            DynamicScale();
=======
            signImage.sprite = Resources.Load<Sprite>(path);   
            ASD();         
>>>>>>> master
        }

        if(VideoSpeedManager.Instance.GetVideoTime() >= routeSignals[0].DeactiveTimeInSeconds[signalOrder]){
            if(signalActive)
                signalOrder++;
            
            signalActive = false;
            signalImage.enabled = false;
        }

        
    }

<<<<<<< HEAD
    void DynamicScale(){
        int distance = routeSignals[0].DeactiveTimeInSeconds[signalOrder] - routeSignals[0].ActiveTimeInSeconds[signalOrder];
        float nowTime = (float) VideoSpeedManager.Instance.GetVideoTime() - routeSignals[0].ActiveTimeInSeconds[signalOrder];
        float scale = nowTime / distance;

        signalImage.transform.localScale = new Vector2(scale,scale);

=======
    void ASD(){
        double timeT = VideoSpeedManager.Instance.GetVideoTime();
        float distance = (float) routeSignals[0].DeactiveTimeInSeconds[signalOrder] - routeSignals[0].ActiveTimeInSeconds[signalOrder];
         
        float st = (float) timeT - routeSignals[0].ActiveTimeInSeconds[signalOrder];
        float scale = st / distance;
        signImage.transform.localScale = new Vector2(scale,scale);
>>>>>>> master
    }

    Signal FindSignal(string id){
        Signal signal = new Signal();
        for (int i = 0; i < signals.Count; i++)
        {
            if(id == signals[i].Id)
            return signals[i];
        }
        return signal;
    }

    public void LoadDataSignal(){
        //Read All Station from json
        string jsonFile = File.ReadAllText(filePathSignal);        
        //Convert json object to Station class object
        Signal[] signals_ = JsonHelper.FromJson<Signal>(jsonFile);   
        //Convert array to list
        signals = new List<Signal>(signals_);
    }

    public void LoadDataRouteSignal(){
        //Read All RouteSignal from json
        string jsonFile = File.ReadAllText(filePathRouteSignal);        
        //Convert json object to RouteSignal class object
        RouteSignal[] routeSignal_ = JsonHelper.FromJson<RouteSignal>(jsonFile);   
        //Convert array to list
        routeSignals = new List<RouteSignal>(routeSignal_);
    }
}
