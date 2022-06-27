using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StairsControll : MonoBehaviour
{
    public static StairsControll instance;
    public List<GameObject> stairs = new List<GameObject>();
    float speed;
    float stairsAnimSpeed;

    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        speed = PlayerPrefs.GetFloat("Speed");
        stairsAnimSpeed = 0.2f / (0.6f / speed);
    }
    public void StairsActiveAnim(int index)
    {        
        stairs[index].transform.Translate(0, 0.2f, 0);
        stairs[index].gameObject.SetActive(true);
        stairs[index].transform.DOMoveY(stairs[index].transform.position.y - 0.2f, stairsAnimSpeed);
    }
    public void StairsChangePosition(int index,int stairsLoopCount)
    {
        if (stairsLoopCount > 0)
        {
            stairs[index].transform.gameObject.SetActive(false);
            stairs[index].transform.Translate(0, 3.746f, 0);
        }
        

    }
   
}
