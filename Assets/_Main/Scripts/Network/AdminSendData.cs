using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;
using MonsterAR.Utility;

namespace MonsterAR.Network{
    [RequireComponent(typeof(NetworkIdentity))]
    public class AdminSendData : Singleton<AdminSendData>
    {
        private NetworkIdentity networkIdentity;
        private Admin admin;       

        void Start(){
            networkIdentity = GetComponent<NetworkIdentity>();
            admin = new Admin();
            
            if(!networkIdentity.GetIsControlling()){
                enabled = false;
            }
        }

        // public void SendNode(){
            
        //     networkIdentity.GetSocket().Emit("NodeLevel",new JSONObject(JsonUtility.ToJson(admin)));
        // }

        // public void RegisterToServer(){
        //     networkIdentity.GetSocket().Emit("RegisterAdmin", new JSONObject(JsonUtility.ToJson(admin)));
        // }
        
        public void Login(string username, string password){  
            
            admin.Username = username;
            admin.Password = password;
                        
            // SendNode();

            networkIdentity.GetSocket().Emit("LoginAdmin", new JSONObject(JsonUtility.ToJson(admin)));
        }
    }
}
