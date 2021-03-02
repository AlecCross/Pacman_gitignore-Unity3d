using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneHealer : MonoBehaviour
{
    private HealthStat healthStat;
    private double hp;
    private bool isRegeneration;
    public Text _endGame;
    GameObject gameMaster;
    Component[] ghostAllParts;
    List<Component> ghostBodyParts;
    GameStats gameStats;
    Renderer _renderer;
    Renderer _rendererGhostPart;
    Color defaultColor;
    void Start()
    {
        if(gameObject.name == "Player"){
        _renderer = GetComponent<Renderer>();
        defaultColor = _renderer.material.GetColor("_Color");
        }
        else{
            ghostAllParts = gameObject.GetComponentsInChildren<Component>();
            foreach(Component c in ghostAllParts){
                    if(c.name == "Sphere"){
                        ghostBodyParts = new List<Component>();
                        ghostBodyParts.Add(c);
                    }
                    else if(c.name == "Sphere.001"){
                        ghostBodyParts.Add(c);
                    }
                    else if(c.name == "Sphere.002"){
                        ghostBodyParts.Add(c);
                    }
                    else if(c.name == "Sphere.003"){
                        ghostBodyParts.Add(c);
                    }
            }
            // foreach(Component sphere in ghostBodyParts){
            //      print("Название- "+sphere.name);
            // }
        }

        
        gameMaster = GameObject.Find("GameMaster");
        gameStats = gameMaster.GetComponent<GameStats>();
        healthStat = gameObject.GetComponent<HealthStat>();
        //print(gameObject.name + " Старт Здоровье " + hp);
        hp = healthStat.hp;
        isRegeneration = healthStat.regeneration;
        //print(gameObject.name + " Присвоили Здоровье " + hp);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Healing" && gameObject.name == "Player")
        {
            if (hp < 99)
            {
                hp += Time.deltaTime * 5;
                 _renderer.material.SetColor("_Color", Color.green);
                //print(gameObject.name + " Увеличение Здоровья " + hp);
            }
            else if (hp >= 99 && hp < 100)
            {
                hp = 100;
                _renderer.material.SetColor("_Color", defaultColor);
                //print(gameObject.name + " Здоров " + hp);
            }
        }
        if (other.tag == "Damager")
        {
            hp -= Time.deltaTime * 15;
            //print(gameObject.name + " Здоровье " + hp);
            isRegeneration = false;
            healthStat.regeneration = isRegeneration;
            healthStat.hp = hp;
            // _renderer.material.SetColor("_Color", Color.red);
        }
        if (other.tag == "Trap" && gameObject.name != "Player")
        {
            hp -= Time.deltaTime * 15;
            //print(gameObject.name + " Здоровье " + hp);
            isRegeneration = false;
            healthStat.regeneration = isRegeneration;
            healthStat.hp = hp;
            foreach(Component sphere in ghostBodyParts){
                    print("Смена цвета для "+sphere.name);
                    _rendererGhostPart = sphere.GetComponent<Renderer>();
                    _rendererGhostPart.material.SetColor("_Color", new Color(1.0f, 0.36f, 0.0f, 1.0f));//255, 98, 68
                }
            StartCoroutine(TrapKiller());
        }
    }
    IEnumerator TrapKiller(){
        //print("Сработала локушка и прибили " + gameObject.name);
        yield return new WaitForSeconds(1.5f);
        //this.gameObject.SetActive(false);
        gameStats.ghostCount--;
        Destroy(this.gameObject);
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Damager" && gameObject.name != "Player")
        {
            isRegeneration = true;
            healthStat.regeneration = isRegeneration;
            foreach(Component sphere in ghostBodyParts){
                 print("Смена цвета для "+sphere.name);
                 _rendererGhostPart = sphere.GetComponent<Renderer>();
                 _rendererGhostPart.material.SetColor("_Color", Color.yellow);
            }
        }
        else if (other.tag == "Healing" && gameObject.name == "Player")
        {
            _renderer.material.SetColor("_Color", defaultColor);
        }
        else if (other.tag == "Damager" && gameObject.name == "Player")
        {
            _renderer.material.SetColor("_Color", defaultColor);
        }
        
    }

    void Update()
    {
        if (hp < 1)
        {
            gameObject.SetActive(false);
            print(gameObject.name + " Убит");
            if (gameObject.name == "Player")
            {
                _endGame.text = "Game Over";
            }
            else if (gameObject.name != "Player")
            {
                //gameStats.ghostCount--;
            }
            
        }
    }

}
