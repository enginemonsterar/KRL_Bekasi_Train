using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterAR.Utility;
using MonsterAR.Network;

public class DoorSystem : Singleton<DoorSystem>
{
    private bool opened;
    
    
    private bool crsActive; //Guard's Switch
    private bool DIRPActive; //Door Interlock Relay by Pass

    public void SetDIRPActive(bool value){
        DIRPActive = value;
    }

    public void SetOpened(bool value){
        opened = value;
        PlayerSendData.Instance.SendDoorStatus(opened);
        if(opened)
            ActionLogManager.Instance.WriteActionLog("Door System", "Door is Opened"); 
        else
            ActionLogManager.Instance.WriteActionLog("Door System", "Door is Closed"); 
    }

    public bool GetDoorOpened(){
        return opened;
    }
}
