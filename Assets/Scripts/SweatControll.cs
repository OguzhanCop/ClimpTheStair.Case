using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SweatControll : MonoBehaviour
{
    public GameObject sweat5;
    public GameObject sweat4;
    public GameObject sweat3;
    public GameObject sweat2;
    public GameObject sweat1;
   
  
    private void Update()
    {
        SweatEfect();
    }
    void SweatEfect()
    {        
        switch (Stamina.instance.stamina)
        {
            
            case 25:
                sweat5.gameObject.SetActive(true);
                sweat4.gameObject.SetActive(false);
                sweat3.gameObject.SetActive(false);
                sweat2.gameObject.SetActive(false);
                sweat1.gameObject.SetActive(false);
                break;
            case 15:
                sweat5.gameObject.SetActive(false);
                sweat4.gameObject.SetActive(true);
                sweat3.gameObject.SetActive(false);
                sweat2.gameObject.SetActive(false);
                sweat1.gameObject.SetActive(false);
                break;
            case 10:
                sweat5.gameObject.SetActive(false);
                sweat4.gameObject.SetActive(false);
                sweat3.gameObject.SetActive(true);
                sweat2.gameObject.SetActive(false);
                sweat1.gameObject.SetActive(false);

                break;
            case 7:
                sweat5.gameObject.SetActive(false);
                sweat4.gameObject.SetActive(false);
                sweat3.gameObject.SetActive(false);
                sweat2.gameObject.SetActive(true);
                sweat1.gameObject.SetActive(false);
                break;
            case 5:
                sweat5.gameObject.SetActive(false);
                sweat4.gameObject.SetActive(false);
                sweat3.gameObject.SetActive(false);
                sweat2.gameObject.SetActive(false);
                sweat1.gameObject.SetActive(true);
                break;        
                
        }
        if (Stamina.instance.stamina > 25)
        {
            sweat5.gameObject.SetActive(false);
            sweat4.gameObject.SetActive(false);
            sweat3.gameObject.SetActive(false);
            sweat2.gameObject.SetActive(false);
            sweat1.gameObject.SetActive(false);

        }

    }

}
