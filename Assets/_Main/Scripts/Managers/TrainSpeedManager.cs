using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterAR.Network;
using MonsterAR.Utility;

public class TrainSpeedManager : Singleton<TrainSpeedManager>
{
    private double acceleration = 0;
    private double speed = 0;
    private double time = 0;
    
    void FixedUpdate(){
        Speeding();
    }

    void Speeding(){
        time = Time.deltaTime;
        speed = speed + acceleration * time;        
        // Debug.Log("Speed: " + speed);
        PlayerSendData.Instance.SendSpeed(speed);
    }

    public void AddAcceleration(double value){
        acceleration += value;
    }

    public void ReduceAcceleration(double value){
        acceleration -= value;
    }

    public double GetSpeed(){        
        return speed;
    }
}
