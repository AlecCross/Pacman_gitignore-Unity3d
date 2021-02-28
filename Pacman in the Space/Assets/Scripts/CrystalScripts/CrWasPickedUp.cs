using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrWasPickedUp : MonoBehaviour
{
    GameObject gameMaster;
    GameStats gameStats;
    void Start(){
        gameMaster = GameObject.Find("GameMaster");
        gameStats = gameMaster.GetComponent<GameStats>();
    }
    void OnTriggerEnter(Collider collider)
    {
        gameStats.pickUpCrystalsCount++;
        if(collider.gameObject.name == "Player")
        print("Поднят кристалл "+ gameStats.pickUpCrystalsCount+ " " + collider.gameObject.name);
        // определение столкновения с двумя разноименными объектами
        if (collider.gameObject.name == "Player")
            
            Destroy(gameObject);
    }
}
