using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WatchController : MonoBehaviour
{
    public TMP_Text text;
    public GameObject LevelController;

    private void Start()
    {
        LevelController = GameObject.FindWithTag("GameController");
        LevelController.GetComponent<LevelController>().UpdateTextOnWatch();
    }
}
