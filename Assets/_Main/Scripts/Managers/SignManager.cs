using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignManager : MonoBehaviour
{
    [SerializeField] private Image[] signImages;
    [SerializeField] private Sprite[] traffic;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Time: " + VideoSpeedManager.Instance.GetVideoTime());
        if(VideoSpeedManager.Instance.GetVideoTime() > 43){
            DeactiveLamp();
        }
        else if(VideoSpeedManager.Instance.GetVideoTime() > 27){
            ActiveLamp();
        }


    }

    void ActiveLamp(){  
        signImages[0].enabled = true;
    }

    void DeactiveLamp(){  
        signImages[0].enabled = false;
    }
}
