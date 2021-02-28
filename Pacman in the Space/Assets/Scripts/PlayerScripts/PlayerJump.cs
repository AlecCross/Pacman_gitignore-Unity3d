using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour{
    PlayerControls controls;
    bool gamepadPlayerJump;
    public Rigidbody _rigidbody;
    private GameObject player;
    void Awake(){
        _rigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        controls = new PlayerControls();
        controls.Gameplay.Jump.performed += ctx => A_Jump();        
    }
    void A_Jump(){
        print("Нажалась кнопка А на геймпаде");
        Jump();
        //gamepadPlayerJump = true;
    }
    void Update(){
        //Попытка присечь подпрыгивание выще двух-трёх прыжков за один раз
        if (player.transform.position.y <= 0.55)
            if (Input.GetKeyDown(KeyCode.Space))
               Jump();
    }
    void Jump(){
        _rigidbody.AddForce(Vector3.up * 350f * 0.02f, ForceMode.VelocityChange);
                        //         rigidbody.AddForce(Vector3.up * 300);
    }
    void OnEnable(){
        controls.Gameplay.Enable();
    }
    void OnDisable(){
        controls.Gameplay.Disable();
    }
}
