using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    
    private void Update()
    {
        PlayerDeathAnim();
    }
    void PlayerDeathAnim()
    {
        if (Stamina.instance.stamina <= 0)
        {
            gameObject.transform.GetChild(7).gameObject.SetActive(true);
            gameObject.transform.GetChild(7).SetParent(null);      
            
            gameObject.SetActive(false);
            TouchControll.instance.CancelInvoke("TouchContinuos");
            UIController.instance.gameStart = false;
            UIController.instance.DeathPanel();
            HeightIndicator.instance.HighScore();
            TouchControll.instance.HightScoreCount();
        }

    }
}
