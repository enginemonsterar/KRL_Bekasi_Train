using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

namespace MonsterAR.Network{
    public class NetworkIdentity : MonoBehaviour
    {
        [Header("Helpful Values")]
        [SerializeField] private string id;
        [SerializeField] private bool isControlling;

        private SocketIOComponent socket;

        void Awake(){
            isControlling = false;
        }
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        

        public void SetControllerID(string ID){
            id = ID;
            //Check incoming id versuses the one we have saved from the server
            isControlling = (NetworkClient.ClientID == ID) ? true : false;             
        }
        public void SetSocketReference(SocketIOComponent socket){
            this.socket = socket;
        }

        public string GetID(){
            return this.id;
        }

        public bool GetIsControlling(){
            return this.isControlling;
        }

        public SocketIOComponent GetSocket(){
            return this.socket;
        }
    }
}
