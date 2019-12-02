using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

namespace MonsterAR.Network{
    [RequireComponent(typeof(NetworkIdentity))]
    public class NetworkTransform : MonoBehaviour
    {
        // [SerializeField]
        // private Vector3 oldPosition;

        // private NetworkIdentity networkIdentity;
        // private Account account;

        // private float stillCounter = 0;

        // void Start(){
        //     networkIdentity = GetComponent<NetworkIdentity>();
        //     oldPosition = transform.position;
        //     account = new Account();
        //     account.position = new Position();
        //     account.position.x = 0;
        //     account.position.y = 0;

        //     if(!networkIdentity.GetIsControlling()){
        //         enabled = false;
        //     }
        // }

        // void Update(){
        //     if(networkIdentity.GetIsControlling()){
        //         if(oldPosition != transform.position){
        //             oldPosition = transform.position;
        //             stillCounter = 0;
        //             SendData();
        //         }else{
        //             stillCounter += Time.deltaTime;

        //             if(stillCounter >= 1){
        //                 stillCounter = 0;
        //                 SendData();
        //             }
        //         }
        //     }
        // }

        // private void SendData(){
        //     //Update account information
        //     account.position.x = transform.position.x;
        //     account.position.x = transform.position.y;

        //     networkIdentity.GetSocket().Emit("updatePosition", new JSONObject(JsonUtility.ToJson(account)));
        // }
    }
}
