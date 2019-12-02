using System;

[Serializable]
public class Admin
{
    public string Id;
    public string Username;
    public string Password;

    public Admin(string id, string username, string password){
        this.Id = id;
        this.Username = username;
        this.Password = password;
    }

    public Admin(){
        
    }
    
}
