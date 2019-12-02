using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MonsterAR.Utility;

public class ConsoleView : Singleton<ConsoleView>
{
    [SerializeField] private GameObject consolePanel;
    [SerializeField] private GameObject notifPanel;
    [SerializeField] private GameObject warningPanel;
    [SerializeField] private GameObject errorPanel;

    public void ShowNotifPanel(string title, string description){
        consolePanel.SetActive(true);
        notifPanel.SetActive(true);
        notifPanel.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Text>().text = title;
        notifPanel.transform.GetChild(0).GetChild(1).GetComponent<Text>().text = description;
    }
    public void ShowNotifPanel(string description){    
        consolePanel.SetActive(true);
        notifPanel.SetActive(true);    
        notifPanel.transform.GetChild(0).GetChild(1).GetComponent<Text>().text = description;
    }

    public void ShowWarningPanel(string title, string description){
        consolePanel.SetActive(true);
        warningPanel.SetActive(true);
        warningPanel.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Text>().text = title;
        warningPanel.transform.GetChild(0).GetChild(1).GetComponent<Text>().text = description;
    }
    public void ShowWarningPanel(string description){
        consolePanel.SetActive(true);
        warningPanel.SetActive(true);        
        warningPanel.transform.GetChild(0).GetChild(1).GetComponent<Text>().text = description;
    }

    public void ShowErrorPanel(string title, string description){
        consolePanel.SetActive(true);
        errorPanel.SetActive(true);
        errorPanel.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Text>().text = title;
        errorPanel.transform.GetChild(0).GetChild(1).GetComponent<Text>().text = description;
    }
    public void ShowErrorPanel(string description){ 
        consolePanel.SetActive(true);
        errorPanel.SetActive(true);        
        errorPanel.transform.GetChild(0).GetChild(1).GetComponent<Text>().text = description;
    }

    public void CloseConsole(){
        consolePanel.SetActive(false);
        notifPanel.SetActive(false);
        warningPanel.SetActive(false);
        errorPanel.SetActive(false);
    }

}
