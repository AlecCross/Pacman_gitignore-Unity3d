using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    Camera gameCamera;
    public Camera playerCamera;
    void Start()
    {
        gameCamera = GetComponent<Camera>();
        gameCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.V)){
            gameCamera.enabled = !gameCamera.enabled;
            playerCamera.enabled = !playerCamera.enabled;
        }
    }
}
