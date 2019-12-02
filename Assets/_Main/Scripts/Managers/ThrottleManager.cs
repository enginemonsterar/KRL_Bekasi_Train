using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterAR.Utility;
using MonsterAR.Network;

public class ThrottleManager : Singleton<ThrottleManager>
{
    private int nodeLevel;
    public enum clutchMode{ front, netral, back }

    private clutchMode clutch = clutchMode.netral;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushThrottle(){
        if(GetClutch() != clutchMode.netral){

            //Check is max or min node
            if(nodeLevel < 4){
                nodeLevel++;
                // Debug.Log(IntNodeToStringNode());

                //For Train Speed Manager
                TrainSpeedManager.Instance.AddAcceleration(0.5f);


                //Send Node Mode Over Network
                PlayerSendData.Instance.SendNodeLevel(nodeLevel);
                ActionLogManager.Instance.WriteActionLog("Ganti Node", IntNodeToStringNode());
                
            }
            
        }
    }
    public void PullThrottle(){
        if(GetClutch() != clutchMode.netral){

            //Check is max or min node            
            if(nodeLevel > -5){
                nodeLevel--;
                // Debug.Log(IntNodeToStringNode());

                //For Train Speed Manager
                TrainSpeedManager.Instance.ReduceAcceleration(0.5f);

                //Send Node Mode Over Network
                PlayerSendData.Instance.SendNodeLevel(nodeLevel);
                ActionLogManager.Instance.WriteActionLog("Ganti Node", IntNodeToStringNode());
            }

        }
    }


    public void SetClutch(clutchMode value){
        clutch = value;
        
        //Send Node Mode Over Network
        PlayerSendData.Instance.SendClutchMode(clutch.ToString());
    }

    public clutchMode GetClutch(){
        return clutch;
    }

    public int GetNodeLevel(){
        return nodeLevel;
    }

    

    private string IntNodeToStringNode(){
        switch (nodeLevel)
        {
            case 0: 
                return "N";
            case 1: 
                return "P1";
            case 2: 
                return "P2";
            case 3: 
                return "P3";
            case 4: 
                return "P4";
            case -1: 
                return "B1";
            case -2: 
                return "B2";
            case -3: 
                return "B3";
            case -4: 
                return "B6";
            case -5: 
                return "EM";
            default:
                return "N";
        }
    }

}
