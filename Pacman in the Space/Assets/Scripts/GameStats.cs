using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour
{
    // Start is called before the first frame update
    public int ghostCount;
    public int pickUpCrystalsCount;
    bool gameOver;
    GameObject directLight;
    Light lightComp;
    Color defaultColor;
    Color setColor;
    void Start()
    {
        
        directLight = GameObject.Find("Directional Light");
        lightComp = directLight.GetComponent<Light>();
        defaultColor = lightComp.color;
        ghostCount = 3;
        setColor=Color.blue;
    }

    void Update()
    { 
        if(!gameOver){
            if(pickUpCrystalsCount==12){
                gameOver = true;   
                print("Уровень завершон победой");
                print("Игрок собрал " + pickUpCrystalsCount+" крист.");
                StartCoroutine("BlueLight");
            }
            if(ghostCount==0){
                gameOver = true;
                print("Все враги унечтожены");
                print("Уровень завершон победой");
                
            }
        }
    }
    IEnumerator BlueLight(){
        
        lightComp.color=setColor;       
        yield return new WaitForSeconds(10f);
        lightComp.color=defaultColor;

    }
}
