using System;
using SocketIO;
using System.Collections;
using System.Collections.Generic;
using WebSocketSharp;
using WebSocketSharp.Net;
using UnityEngine;
using MonsterAR.Utility;

namespace MonsterAR.Network{
    
    public class NetworkClient : SocketIOComponent
    {        
        [Header("Network Client")]
        [SerializeField] private Transform networkContainer;
        private Dictionary<string, NetworkIdentity> serverObjects;
        [SerializeField] private GameObject adminClientPrefab;
        [SerializeField] private GameObject playerClientPrefab;

        public static string ClientID {get; private set;}
        public override void Start(){
            base.Start();
            Initialize();
            SetupEvents();
        }
        public override void Update(){
            base.Update();
        }

        private void Initialize(){
            serverObjects = new Dictionary<string, NetworkIdentity>();
            
        }

        public void SetClientID(string clientID){
            ClientID = clientID;
        }

        private void SetupEvents(){             
            On("open", (E) => {
                Debug.Log("Connection made to The Server");                
            });

            On("CheckLoggedAdmin_", (E) => {                                
                Debug.Log("Get Node Level: " + E.data["Level"]);   
                
            });

            On("NodeLevel_", (E) => {                                
                Debug.Log("Get Node Level: " + E.data["Level"]);   
                
            });

            // On("checkAdminLoged", (E) => {
            //     string value = E.data["adminLoged"].ToString();
            //     if(value == "true"){
            //         SceneController.Instance.GoToScene("Main");
            //     }else{
            //         ConsoleController.Instance.ShowError("Operator Belum Aktif");
            //     }
            // });

            // On("registerAdmin", (E) => {                                
            //     ClientID = E.data["id"].ToString();
            //     Debug.LogFormat("Our Client's Server ID: ({0})", ClientID);
            // });

            // On("spawnAdmin", (E) => {
            //     Debug.Log("spawn admin");
            //     //Handling all spawning 
            //     //Passed data
            //     string id = E.data["id"].ToString();
            //     GameObject go = Instantiate(adminClientPrefab, networkContainer);
            //     go.name = string.Format("Admin");
            //     NetworkIdentity ni = go.GetComponent<NetworkIdentity>();
            //     ni.SetControllerID(id); 
            //     ni.SetSocketReference(this);                
            //     serverObjects.Add(id, ni);
            // });
            // On("toOperator", (E) => {
            //     Debug.Log("To Operator");
            //     ClientID = E.data["gigi"].ToString();
            //     Debug.LogFormat("GIGI: ({0})", ClientID);
            // });
            

            

            // On("disconnected", (E) => {
            //     string id = E.data["id"].ToString();
            //     GameObject go = serverObjects[id].gameObject;
            //     Destroy(go); // Remove from Game
            //     serverObjects.Remove(id); //remove from memory
            // });

            // On("sendMessage", (E) => {
            //     string id = E.data["id"].ToString();
            //     string username = E.data["username"].str;
            //     string message = E.data["message"].str;

            //     // GameManager.Instance.GetChatManager().SpawnOtherChat(username, message);

            //     NetworkIdentity ni = serverObjects[id];
                
            // });

            
        }
        
    }
        
}
