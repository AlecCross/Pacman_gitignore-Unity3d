using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    public float charSpeed = 5f;
    public float turnSpeed = 50f;
    PlayerControls controls;
    Vector2 move;

    // controls.Gameplay.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
    //     controls.Gameplay.Move.canceled += ctx => move = Vector2.zero;
    void FixedUpdate()
    //фиксированная частота срабатываний
    {
        if (Input.GetKey(KeyCode.W))// || Input.GetKey(KeyCode.JoystickButton19))
           Up();  
        if (Input.GetKey(KeyCode.S))// || Input.GetKey(KeyCode.JoystickButton18))
            Down();
        if (Input.GetKey(KeyCode.A))// || Input.GetKey(KeyCode.JoystickButton17))
            Left();
        if (Input.GetKey(KeyCode.D))// || Input.GetKey(KeyCode.JoystickButton16))
            Right();
        //Vector3 это значит что точка находится в 3х мерном пространстве
    }
    void Awake(){
        controls = new PlayerControls();
        //controls.Gameplay.MoveUpDpad.performed += ctx => Up();
        controls.Gameplay.MoveUpDpad.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.MoveUpDpad.performed += ctx => move = Vector2.zero;
        //controls.Gameplay.MoveDownDpad.performed += ctx => Down();
        controls.Gameplay.MoveDownDpad.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.MoveDownDpad.performed += ctx => move = Vector2.zero;
        //controls.Gameplay.MoveLeftDpad.performed += ctx => Left();
        controls.Gameplay.MoveLeftDpad.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.MoveLeftDpad.performed += ctx => move = Vector2.zero;
        //controls.Gameplay.MoveRightDpad.performed += ctx => Right();
        controls.Gameplay.MoveRightDpad.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Gameplay.MoveRightDpad.performed += ctx => move = Vector2.zero;
    }
    void Up(){
        transform.Translate(Vector3.forward * charSpeed * Time.deltaTime);
    }
    void Down(){
        transform.Translate(Vector3.back * charSpeed * Time.deltaTime);
    }
    void Left(){
        transform.Translate(Vector3.left * charSpeed * Time.deltaTime);
    }
    void Right(){
        transform.Translate(Vector3.right * charSpeed * Time.deltaTime);
    }
    void Update(){
        Vector2 m = new Vector2(-move.x, move.y) * Time.deltaTime;
         transform.Translate(m, Space.World);
    }
    void OnEnable(){
        controls.Gameplay.Enable();
    }
    void OnDisable(){
        controls.Gameplay.Disable();
    }
}
