using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControll : MonoBehaviour
{
    public static PlaneControll instance;
    int changePlane =0;

    private void Awake()
    {
        instance = this;
        
    }  
   

    public void ChangePlanePos()
    {
        if (changePlane == 0)
        {
            gameObject.transform.GetChild(0).Translate(0, 15.972f, 0);
            changePlane = 1;
        }
        else if (changePlane == 1)
        {
            gameObject.transform.GetChild(1).Translate(0, 15.972f, 0);
            changePlane = 2;
        }
        else if (changePlane == 2)
        {
            gameObject.transform.GetChild(2).Translate(0, 15.972f, 0);
            changePlane = 0;
        }

    }
}
