using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{

    private void Update()
    {
        if (PlayerPrefs.HasKey("Stamina") == false)
        {
            PlayerPrefs.SetInt("Stamina", 30);
        }
        if (PlayerPrefs.HasKey("Income") == false)
        {
            PlayerPrefs.SetInt("Income", 0);
        }
        if (PlayerPrefs.HasKey("Speed") == false)
        {
            PlayerPrefs.SetFloat("Speed", 0.6f);
        }
        if (PlayerPrefs.HasKey("StaminaLvl") == false)
        {
            PlayerPrefs.SetInt("StaminaLvl", 1);
        }
        if (PlayerPrefs.HasKey("IncomeLvl") == false)
        {
            PlayerPrefs.SetInt("IncomeLvl", 1);
        }
        if (PlayerPrefs.HasKey("SpeedLvl") == false)
        {
            PlayerPrefs.SetInt("SpeedLvl", 1);
        }
        if (PlayerPrefs.HasKey("ScoreMajor") == false)
        {
            PlayerPrefs.SetInt("ScoreMajor", -500);
        }
        if (PlayerPrefs.HasKey("ScoreMinor") == false)
        {
            PlayerPrefs.SetInt("ScoreMinor", 0);
        }
        if (PlayerPrefs.HasKey("StairCount") == false)
        {
            PlayerPrefs.SetInt("StairCount", 2);
        }
    }
}
