using System;

[Serializable]
public class ActionLog
{
    public string Name;
    public string Value;
    public DateTime DateTime;

    public ActionLog(string name, string value, DateTime dateTime){
        this.Name = name;
        this.Value = value;
        this.DateTime = dateTime;
    }

    public ActionLog(){

    }    
}
