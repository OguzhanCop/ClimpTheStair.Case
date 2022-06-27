using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelContinue : MonoBehaviour
{
    public static LevelContinue instance;
    public GameObject player;
    public GameObject deathEffect;
    private void Awake()
    {
        instance = this;
    }

    public void Continue()
    {
        Stamina.instance.stamina = PlayerPrefs.GetInt("Stamina");
        Time.timeScale = 1;
        UIController.instance.gameStart = true;
        player.gameObject.SetActive(true);
        Instantiate(deathEffect, player.transform.position,Quaternion.identity).transform.SetParent(player.transform);
       
        
    }
   
}
