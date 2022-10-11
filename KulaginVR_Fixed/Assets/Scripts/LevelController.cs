using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelController : MonoBehaviour
{
    public GameObject Watch;
    private TMP_Text watchText;


    //Level Info
    public int _LevelID;
    public string _LevelName;
    public int _TrophyCount;
    public int _CollectedTrophy;

    public Level level;



    public void AddTrophy()
    {
        _CollectedTrophy++;
        UpdateTextOnWatch();
        CheckCompleted();
    }
    private bool CheckCompleted()
    {
        if (_CollectedTrophy >= _TrophyCount)
            return true;
        return false;
    }

    public void UpdateTextOnWatch()
    {
        if (Watch == null)
        {
            Watch = GameObject.FindWithTag("Watch");
            watchText = Watch.GetComponent<WatchController>().text;
        }
            
        watchText.text = $"{_CollectedTrophy}/{_TrophyCount}";
    }
}

[SerializeField]
public class Level
{
    public int LevelId { get; set; }
    public string LevelName { get; set; }
    public int MaxTrophyCount { get; set; }
    public int CollectTrophy { get; set; }
    public bool LevelCompleted{ get; set; }
}
