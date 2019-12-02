using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterAR.Utility;

public class ConsoleController : Singleton<ConsoleController>
{
    public void ShowNotif(string title, string description){
        ConsoleView.Instance.ShowNotifPanel(title, description);
    }
    public void ShowNotif(string description){
        ConsoleView.Instance.ShowNotifPanel(description);
    }

    public void ShowWarning(string title, string description){
        ConsoleView.Instance.ShowWarningPanel(title, description);
    }
    public void ShowWarning(string description){
        ConsoleView.Instance.ShowWarningPanel(description);
    }

    public void ShowError(string title, string description){
        ConsoleView.Instance.ShowErrorPanel(title, description);
    }
    public void ShowError(string description){
        ConsoleView.Instance.ShowErrorPanel(description);
    }
}
