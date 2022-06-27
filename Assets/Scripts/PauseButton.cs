using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
  
    void Start()
    {
        
    }

    
    public void PauseButtonClick()
    {
        Time.timeScale = 0;
        UIController.instance.gameStart = false;
        UIController.instance.PauseButton();

    }
}
