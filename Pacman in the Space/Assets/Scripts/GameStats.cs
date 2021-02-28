using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour
{
    // Start is called before the first frame update
    public int ghostCount;
    public int pickUpCrystalsCount;
    bool gameOver;
    void Start()
    {
        ghostCount = 3;
    }

    // Update is called once per frame
    void Update()
    { 
        if(!gameOver){
            if(pickUpCrystalsCount==12){
                gameOver = true;   
                print("Уровень завершон победой");
                print("Игрок собрал " + pickUpCrystalsCount+" крист.");
            }
            if(ghostCount==0){
                gameOver = true;
                print("Все враги унечтожены");
                print("Уровень завершон победой");
            }
        }
    }
}
