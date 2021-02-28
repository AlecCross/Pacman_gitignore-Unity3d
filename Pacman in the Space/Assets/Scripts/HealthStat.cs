using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthStat : MonoBehaviour{
    public double hp;
    public bool regeneration;
    public double regnStep;

    // Start is called before the first frame update
    void Start(){
        hp = 100;
        if (gameObject.name != "Player"){
            regeneration = true;
            //print(gameObject.name + " Присвоен статус регенерация");
        }
        if (regeneration){
            //print(gameObject.name + " Началась регенерация");
            regnStep = 1;
            StartCoroutine("Regeneration");
        }
    }

    IEnumerator Regeneration(){
        while (true){
            if (hp > 0 || hp < 100){
                //print(gameObject.name + " Здоровье "+hp+" увеличино на "+regnStep);
                hp += regnStep;
                yield return new WaitForSeconds(5f);
            }
        }
    }
}
