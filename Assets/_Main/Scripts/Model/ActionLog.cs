using System;

[Serializable]
public class ActionLog
{
    public string LogHistoryId;
    public string Name;
    public string Value;
    public int Day;
    public int Month;
    public int Year;
    public int Hour;
    public int Minute;
    public int Second;

    public ActionLog(string logHistoryId, string name, string value, DateTime dateTime){
        this.LogHistoryId = logHistoryId;
        this.Name = name;
        this.Value = value;
        this.Day = DateTime.Now.Day;
        this.Month = DateTime.Now.Month;
        this.Year = DateTime.Now.Year;
        this.Hour = DateTime.Now.Hour;
        this.Minute = DateTime.Now.Minute;
        this.Second = DateTime.Now.Second;

    }

    public ActionLog(string logHistoryId,string name, string value, int day, int month, int year, int hours, int minutes, int seconds){
        this.LogHistoryId = logHistoryId;
        this.Name = name;
        this.Value = value;
        this.Day = day;
        this.Month = month;
        this.Year = year;
        this.Hour = hours;
        this.Minute = minutes;
        this.Second = seconds;
    }

    public ActionLog(){

    }    
}
