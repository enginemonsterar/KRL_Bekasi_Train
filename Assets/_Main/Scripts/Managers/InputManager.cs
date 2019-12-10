using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterAR.Utility;

public class InputManager : Singleton<InputManager>
{
    

    // Update is called once per frame
    void Update()
    {

        //Throttle Controller
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            PushThrottle();
        }else if(Input.GetKeyDown(KeyCode.DownArrow)){
            PullThrottle();
        }

        //Clutch Controller
        if(Input.GetKeyDown(KeyCode.W)){
            PushClutch();
        }else if(Input.GetKeyDown(KeyCode.S)){
            PullClutch();
        }else if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S)){
            NetralClutch();
        }

        //Deadman Controller
        if(Input.GetKeyDown(KeyCode.D)){
            PressDeadmanPedal();
        }else if(Input.GetKeyUp(KeyCode.D)){
            UnPressDeadmanPedal();
        }

        //Horn Controller        
        if(Input.GetKeyDown(KeyCode.H)){
            PressHorn();
        }else if(Input.GetKeyUp(KeyCode.H))
            UnPressHorn();

        //Door Controller        
        if(Input.GetKeyDown(KeyCode.O) && !DoorSystem.Instance.GetDoorOpened()){
            OpenDoor();
        } else if(Input.GetKeyDown(KeyCode.P) && DoorSystem.Instance.GetDoorOpened()){
            CloseDoor();
        }
        
    }

    public void SetMessage(string message){
        Debug.Log(message);
        switch (message)
        {
            case "Deadman: OFF": 
                Debug.Log("Deadman UnPressed");
                UnPressDeadmanPedal();
                break;
            case "Deadman: ON": 
                Debug.Log("Deadman Pressed");
                PressDeadmanPedal();
                break;
            case "Control: F P1": 
                ThrottleManager.Instance.SetThrottle(1);
                break;
            case "Control: F P2": 
                ThrottleManager.Instance.SetThrottle(2);
                break;
            case "Control: F P3": 
                ThrottleManager.Instance.SetThrottle(3);
                break;
            case "Control: F P4": 
                ThrottleManager.Instance.SetThrottle(4);
                break;
            case "Control: F B1": 
                ThrottleManager.Instance.SetThrottle(-1);
                break;
            case "Control: F B2": 
                ThrottleManager.Instance.SetThrottle(-2);
                break;
            case "Control: F B3": 
                ThrottleManager.Instance.SetThrottle(-3);
                break;
            case "Control: F B4": 
                ThrottleManager.Instance.SetThrottle(-4);
                break;
            default:
                break;
        }
    }

    void OpenDoor(){
        Debug.Log("OpenDoor");
        DoorSystem.Instance.SetOpened(true);
    }
    void CloseDoor(){
        Debug.Log("OpenDoor");
        DoorSystem.Instance.SetOpened(false);
    }
    void PressHorn(){
        HornSystem.Instance.PressHorn();
    }
    void UnPressHorn(){
        HornSystem.Instance.UnPressHorn();
    }

    void PressDeadmanPedal(){
        DeadmanSystem.Instance.SetPressed(true);
        
    }

    void UnPressDeadmanPedal(){
        DeadmanSystem.Instance.SetPressed(false);
        
    }

    void PushThrottle(){
        
        ThrottleManager.Instance.PushThrottle();
    }

    void PullThrottle(){
        ThrottleManager.Instance.PullThrottle();
    }

    void PushClutch(){
        ThrottleManager.Instance.SetClutch(ThrottleManager.clutchMode.front);
    }
    void NetralClutch(){
        ThrottleManager.Instance.SetClutch(ThrottleManager.clutchMode.netral);
    }
    void PullClutch(){
        ThrottleManager.Instance.SetClutch(ThrottleManager.clutchMode.back);
    }
}
