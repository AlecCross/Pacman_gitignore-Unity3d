using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalJump : MonoBehaviour
{
    GameObject portal1, portal2, portal3, portal4;
    void Awake(){
        portal1 = GameObject.Find("Portal");
        portal2 = GameObject.Find("Portal2");
        portal3 = GameObject.Find("Portal3");
        portal4 = GameObject.Find("Portal4");
    }
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Portal")
            gameObject.transform.position = portal2.transform.position + new Vector3(0, 0, 2);
        else if (collider.gameObject.name == "Portal2")
            gameObject.transform.position = portal1.transform.position + new Vector3(2, 0, 0);
        else if (collider.gameObject.name == "Portal3")
            gameObject.transform.position = portal4.transform.position + new Vector3(-2, 0, 0);
        else if (collider.gameObject.name == "Portal4")
            gameObject.transform.position = portal3.transform.position + new Vector3(0, 0, 2);
    }
}
