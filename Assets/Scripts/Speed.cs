using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public static Speed instance;
    float speed;

    private void Awake()
    {
        instance = this;
    }
    public void SpeedButton()
    {
        speed = PlayerPrefs.GetFloat("Speed");
        speed = speed - (speed * 0.02f);
        PlayerPrefs.SetFloat("Speed", speed);
    }

}
