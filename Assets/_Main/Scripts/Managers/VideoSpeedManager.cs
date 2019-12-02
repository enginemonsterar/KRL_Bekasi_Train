using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using MonsterAR.Utility;
using MonsterAR.Network;

public class VideoSpeedManager : Singleton<VideoSpeedManager>
{
    private VideoPlayer videoPlayer;

    void Awake(){
        videoPlayer = GetComponent<VideoPlayer>();
    }

    void Start(){
        videoPlayer.playbackSpeed = 0;
        InvokeRepeating("Speeding",1,0.1f);
        
    }

    void Update(){
        PlayerSendData.Instance.SendVideoTime(GetVideoTime());
    }
    
    void Speeding(){
        StartCoroutine(Speeding_());
    }
    
    IEnumerator Speeding_(){
        yield return new WaitForEndOfFrame();
        
        videoPlayer.playbackSpeed = (float) TrainSpeedManager.Instance.GetSpeed() / 15;

    }

    public double GetVideoTime(){        
        return videoPlayer.time;
    }
}
