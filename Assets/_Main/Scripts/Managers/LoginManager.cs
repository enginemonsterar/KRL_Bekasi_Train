using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using MonsterAR.Utility;
using MonsterAR.Network;

public class LoginManager : Singleton<LoginManager>
{
    [Header("UI")]
    [SerializeField] private InputField nameInputField;
    [SerializeField] private InputField passInputField;

    [Header("Network")]
    [SerializeField] private NetworkClient netClient;
    
    [SerializeField] private GameObject playerClientPrefab;
    [SerializeField] private Transform networkContainer;
    
    private List<Player> players;
    
    private string filePathPlayer;
    
    void Awake(){
        // Debug.Log(Application.dataPath);        
        filePathPlayer = Application.dataPath  + "/_Main" + "/Scripts" + "/JSON" + "/Player.json";
    }


    public void LoadDataPlayer(){
        //Read All Player from json
        string jsonFile = File.ReadAllText(filePathPlayer);        
        //Convert json object to Player class object
        Player[] player_ = JsonHelper.FromJson<Player>(jsonFile);   
        //Convert array to list
        players = new List<Player>(player_);
    }

    public void PlayerTryToLogin(){

        

        LoadDataPlayer();

        string name = nameInputField.text;
        string pass = passInputField.text;

        Player player = new Player("0",name,pass);

        if(players.Exists(x => x.Username == player.Username) && players.Exists(x => x.Password == player.Password)){            
            netClient.SetClientID(player.Id);
            
            GameObject go = Instantiate(playerClientPrefab, networkContainer);
            go.name = string.Format("Player");
            string id = player.Id;
            NetworkIdentity ni = go.GetComponent<NetworkIdentity>();
            ni.SetControllerID(id); 
            ni.SetSocketReference(netClient);
            StartCoroutine(PlayerLoginToServer(player.Username, player.Password));
            
        }else{
            ConsoleController.Instance.ShowError("Username dan Password tidak cocok!");
        }
        
    }

    IEnumerator PlayerLoginToServer(string username, string password){
        yield return new WaitForEndOfFrame();
        PlayerSendData.Instance.Login(username,password);
        
        SceneController.Instance.GoToScene("Main");
    }

    
}
