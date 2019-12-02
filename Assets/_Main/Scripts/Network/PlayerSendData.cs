using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;
using MonsterAR.Utility;

namespace MonsterAR.Network{
    [RequireComponent(typeof(NetworkIdentity))]
    public class PlayerSendData : Singleton<PlayerSendData>
    {
        private NetworkIdentity networkIdentity;
        private Player player;       

        void Start(){
            networkIdentity = GetComponent<NetworkIdentity>();
            player = new Player();
            
            if(!networkIdentity.GetIsControlling()){
                enabled = false;
            }
        }

        public void SendNodeLevel(int value){            
            NodeLevel nLevel = new NodeLevel(value);
            networkIdentity.GetSocket().Emit("NodeLevel",new JSONObject(JsonUtility.ToJson(nLevel)));
        }

        public void SendClutchMode(string clutchName){            
            ClutchMode clutchMode = new ClutchMode(clutchName);
            networkIdentity.GetSocket().Emit("ClutchMode",new JSONObject(JsonUtility.ToJson(clutchMode)));
        }

        public void SendSpeed(double speed){            
            TrainSpeed trainSpeed = new TrainSpeed(speed);
            networkIdentity.GetSocket().Emit("TrainSpeed",new JSONObject(JsonUtility.ToJson(trainSpeed)));
        }

        public void SendDeadman(bool pressed){            
            Deadman deadman = new Deadman(pressed);
            networkIdentity.GetSocket().Emit("Deadman",new JSONObject(JsonUtility.ToJson(deadman)));
        }
        public void SendDoorStatus(bool opened){            
            DoorStatus doorStatus = new DoorStatus(opened);
            networkIdentity.GetSocket().Emit("DoorSystem",new JSONObject(JsonUtility.ToJson(doorStatus)));
        }
        public void SendHorn(bool hornStatus){            
            HornStatus hornStatus_ = new HornStatus(hornStatus);
            networkIdentity.GetSocket().Emit("HornStatus",new JSONObject(JsonUtility.ToJson(hornStatus_)));
        }
        public void SendVideoTime(double videoTime){            
            VideoTime videoTime_ = new VideoTime(videoTime);
            networkIdentity.GetSocket().Emit("VideoTime",new JSONObject(JsonUtility.ToJson(videoTime_)));
        }

        public void SendActionLog(ActionLog actionLog){                        
            networkIdentity.GetSocket().Emit("ActionLog",new JSONObject(JsonUtility.ToJson(actionLog)));
        }

        // public void RegisterToServer(){
        //     networkIdentity.GetSocket().Emit("RegisterAdmin", new JSONObject(JsonUtility.ToJson(admin)));
        // }
        
        public void Login(string username, string password){  
            
            player.Username = username;
            player.Password = password;
                        
            
            
            networkIdentity.GetSocket().Emit("LoginPlayer", new JSONObject(JsonUtility.ToJson(player)));
        }
    }
}
