using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBoxKiller : MonoBehaviour
{
    GameObject gameMaster;
    GameStats gameStats;
    void Start(){
        gameMaster = GameObject.Find("GameMaster");
        gameStats = gameMaster.GetComponent<GameStats>();
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "GhostTag")
        {
            GameObject.Find(collider.gameObject.name).SetActive(false);
            gameStats.ghostCount--;
        }
    }
}
