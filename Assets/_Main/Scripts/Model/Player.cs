using System;

[Serializable]
public class Player
{
    public string Id;
    public string Username;
    public string Password;

    public Player(string id, string username, string password){
        this.Id = id;
        this.Username = username;
        this.Password = password;
    }

    public Player(){
        
    }
    
}
