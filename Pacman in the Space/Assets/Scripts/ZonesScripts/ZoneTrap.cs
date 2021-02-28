using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneTrap : MonoBehaviour
{
    GameObject spaceShip;
    SpaceShipRotation spaceShipRotation;
    bool rotate;
    bool isKinematic;
    Rigidbody rb;
    void Start(){
        spaceShip = GameObject.Find("SpaceShip");
        //print("Найдена летающая тарелка " + spaceShip.name);
        spaceShipRotation = spaceShip.GetComponent<SpaceShipRotation>();
        rotate = spaceShipRotation.rotate;
        rb = spaceShip.GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other){
        if (other.tag == "Trap" && gameObject.name != "Player"){
            //print("Летающая тарелка перестаёт вращаться" + spaceShip.name);
            StartCoroutine(spaceShipRotation.StopRotation());

            StartCoroutine("Attacks_TakesPosition");
            StartCoroutine(Up());
        }
    }
    IEnumerator Attacks_TakesPosition(){
        print("Коротина начала работу");
        yield return new WaitForSeconds(1f);
        rb.isKinematic = false;
        yield return new WaitForSeconds(1.9f);
    }
    IEnumerator Up(){
        yield return new WaitForSeconds(2.9f);
        rb.isKinematic = true;
        yield return new WaitForSeconds(1f);
        print("Коротина начинает подниматься");
        for (int i = 0; i < 15; i++){
            print("Тарелка поднимается");
            spaceShip.transform.position += Vector3.up * i * Time.deltaTime;
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(1f);
        print("Коротина закончила работу");
    }
}

 // void OnCollisionEnter(Collision collision){
    //     if(collision.gameObject.tag == "GhostTag")
    //     Destroy(collision.gameObject);
    // }
    
    // void OnCollisionEnter(Collision collision){
        // if (other.tag == "Trap" && gameObject.name != "Player")
        // {
        //     // print("Летающая тарелка восстановила вращение" + spaceShip.name);
        //     // StartCoroutine(spaceShipRotation.Rotation());      
        //     //Первый раз при заходе в зону ловушки, вращение летающей тарелки останавливается
        //     //А после выхода из зоны ловушки тарелка крутиться, но это судя по всему запускается новый скрипт.
        //     //Так же если зайти в ловушку запущеный скрипт перед этим не доступен и остановка срабоатывает для нового скрипта
        //     //Каждый выход из ловушки сумирует суорость вращения тарелки... 
        //     //Пока что запутался.
        // }
    //      if(collision.gameObject.tag == "Trap")
    //      print("Тарелка коснулась к призраку");
    //     Destroy(collision.gameObject);
    // }


