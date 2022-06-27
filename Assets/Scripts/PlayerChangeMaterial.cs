using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangeMaterial : MonoBehaviour
{
    public Material tired0;
    public Material tired20;
    public Material tired40;
    public Material tired60;
    public Material tired80;
    public Material tired100;
    
    void Update()
    {
        ChangeMaterial();
        
       
    }
    public void ChangeMaterial()
    {
        switch (Stamina.instance.stamina)
        {
            case 1:
                gameObject.GetComponent<Renderer>().material = tired100;
                break;
            case 5:
                gameObject.GetComponent<Renderer>().material = tired80;
                break;
            case 9:
                gameObject.GetComponent<Renderer>().material = tired60;
                break;
            case 12:
                gameObject.GetComponent<Renderer>().material = tired40;
                break;

            case 15:
                gameObject.GetComponent<Renderer>().material = tired20;
                break;
            
        }
        if(Stamina.instance.stamina>15)
            gameObject.GetComponent<Renderer>().material = tired0;
    }
}
