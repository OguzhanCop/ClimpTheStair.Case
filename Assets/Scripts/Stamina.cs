using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour
{
    public static Stamina instance;
    public float stamina;
    

    private void Awake()
    {
        instance = this;
        stamina = PlayerPrefs.GetInt("Stamina");
    }
    void Start()
    {
        StartCoroutine(StaminaIncrease());       
    }
  
    public void StaminaDecrease()
    {
        stamina--;    

    }   
  
    IEnumerator StaminaIncrease()
    {     
       
       while(true)
        {
            if (PlayerControll.instance.climping)
            {
               
                yield return new WaitForSeconds(1f);
            }
            else
            {
                if (stamina < PlayerPrefs.GetInt("Stamina"))
                {
                    stamina++;
                    yield return new WaitForSeconds(1f);
                }
                else
                    yield return new WaitForSeconds(1f);
            }          


        }
        
    }
}
