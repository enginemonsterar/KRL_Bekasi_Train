using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterAR.Utility;
using MonsterAR.Network;

public class HornSystem : Singleton<HornSystem>
{
    public void PressHorn(){
        PlayerSendData.Instance.SendHorn(true);
        ActionLogManager.Instance.WriteActionLog("Horn System", "Horn Pressed"); 
    }
    public void UnPressHorn(){
        PlayerSendData.Instance.SendHorn(false);
        ActionLogManager.Instance.WriteActionLog("Horn System", "Horn UnPressed"); 
    }
}
