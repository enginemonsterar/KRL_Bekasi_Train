using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterAR.Utility;
using MonsterAR.Network;

public class DeadmanSystem : Singleton<DeadmanSystem>
{
    private bool pressed;
    private float time;
    private float deadTime = 6;
    private float cheatTime = 6;

    private bool reseted = true;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        if(pressed){
            time += Time.deltaTime;
            if(time >= cheatTime){
                ManIsCheat();
            }
        }else{

            time += Time.deltaTime;
            if(time >= deadTime){
                ManIsDead();
            }

        }
    }

    public void SetPressed(bool pressed){
        this.pressed = pressed;
        time = 0;
        PlayerSendData.Instance.SendDeadman(this.pressed);
        if(this.pressed){

            reseted = true;
            ActionLogManager.Instance.WriteActionLog("Deadman System", "Deadman Pedal Pressed");                   
        }
        else if(!this.pressed){
            reseted = true;
            ActionLogManager.Instance.WriteActionLog("Deadman System", "Deadman Pedal UnPressed");                   

        }
    }

    void ManIsDead(){        
        if(reseted){
            Debug.Log("Man Is Dead");
            reseted = false;
            ActionLogManager.Instance.WriteActionLog("Deadman System", "Man Is Dead");
        }
    }
    void ManIsCheat(){
        if(reseted){
            Debug.Log("Man Is Cheat");
            reseted = false;
            ActionLogManager.Instance.WriteActionLog("Deadman System", "Man Is Cheat");
        }
    }
}
