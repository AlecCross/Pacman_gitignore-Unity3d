using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;
     GameObject gameMaster;
    GameStats gameStats;
    void Start(){
        gameMaster = GameObject.Find("GameMaster");
        gameStats = gameMaster.GetComponent<GameStats>();
        StartCoroutine(Spawn(3));
    }

    void spawnGhost(){
        GameObject ghostObj = Instantiate(
                        enemyPrefab, 
                        gameObject.transform.position+new Vector3(2,0,0),
                        //new Vector3(1,5,0), 
                        Quaternion.identity);
        //print("Заспавнило " + ghostObj.name);
    }

    public IEnumerator Spawn(int count){
        yield return new WaitForSeconds(1f);
        for(int i=0; i<count; i++){
            yield return new WaitForSeconds(2f);
            spawnGhost();
        }
    }
    void OnTriggerExit(Collider other)
    {
        //print("Определён игрок");
        StartCoroutine(
                        ReactionOnDetect(other)
                      );
    }
    IEnumerator ReactionOnDetect(Collider collider)
    {
        if (collider.tag == "Player")
        {
            StartCoroutine(Spawn(1));
            yield return new WaitForSeconds(1f);
            gameStats.ghostCount++;
        }
        //+1 призрак к первым 3м в начале игры
        
    }

}

