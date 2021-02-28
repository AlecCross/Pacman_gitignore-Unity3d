using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision_Enemy_Player : MonoBehaviour{
    string playerName = "Player";
    public Text _endGame;
    GameObject player;
    void Start(){
        player = GameObject.Find(playerName);
    }
    void OnCollisionEnter(Collision collider){
        if (collider.gameObject.name == player.name){
            //_endGame.text = "Game Over";
            player.SetActive(false);
            print(playerName + "Убит!");
            return;
        }
    }
}

