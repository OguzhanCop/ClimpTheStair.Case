using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public static Money instance;
    public float moneyScore;
    
    private void Awake()
    {
        instance = this;
        moneyScore = PlayerPrefs.GetInt("Income");
    }
   

    public void MoneyIncrease()
    {
        moneyScore += 0.4f + (0.1f * PlayerPrefs.GetInt("IncomeLvl"));
        PlayerPrefs.SetInt("Income",(int) moneyScore);

    }
    public void MoneyDecrease(int upgradeMoney)
    {
        moneyScore -= upgradeMoney;
        PlayerPrefs.SetInt("Income", (int)moneyScore);

    }
}
