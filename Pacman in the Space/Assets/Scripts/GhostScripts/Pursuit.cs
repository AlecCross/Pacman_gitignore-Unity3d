using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuit : MonoBehaviour
{
    Rigidbody _rigidbody;
    GameObject player;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        player = GameObject.Find("Player");
    }
    void Update()
    {
        float speed = 2;
        // Move our position a step closer to the target.
        float step = speed * Time.deltaTime; // calculate distance to move

        transform.position = Vector3.MoveTowards(transform.position,
        player.transform.position, step);
    }

    //Как найти объект
    //как найти координату
    //Как двигаться в координату
}
