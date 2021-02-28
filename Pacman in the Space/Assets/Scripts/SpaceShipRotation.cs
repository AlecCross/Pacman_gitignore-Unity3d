using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipRotation : MonoBehaviour{
    GameObject spaceShip;
    public bool rotate;
    void Avake(){
        StartCoroutine("Rotation");
    }
    void Start(){
        spaceShip = gameObject;
        if(!rotate){
            StartCoroutine("Rotation");
        }
        else{
            StopCoroutine("Rotation");
        }
    }
    void Update(){
        if(!rotate){
            StartCoroutine("Rotation");
        }
        else{
            //StartCoroutine("StopRotation");
        }
    }
    // Update is called once per frame
    public IEnumerator Rotation(){   
        //spaceShip.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 45, 0);
        spaceShip.transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
        yield return new WaitForSeconds(0.01f);
        //print("Корутина - "+i++);
    }
    public IEnumerator StopRotation(){   
        StopCoroutine("Rotation");
        // spaceShip.GetComponent<Rigidbody>().angularVelocity = new Vector3(40, 0, 0);
        // yield return new WaitForSeconds(10f);
        // spaceShip.GetComponent<Rigidbody>().angularVelocity = new Vector3(30, 0, 0);
        // yield return new WaitForSeconds(10f);
        // spaceShip.GetComponent<Rigidbody>().angularVelocity = new Vector3(10, 0, 0);
        // yield return new WaitForSeconds(10f);
        // spaceShip.GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        
        
        //spaceShip.GetComponent<Rigidbody>().angularVelocity = new Vector3(40, 0, 0);
        //spaceShip.transform.Rotate(new Vector3(0, 45, 0) * 0);
        yield return new WaitForSeconds(10f);
    }
}
