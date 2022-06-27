using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControll : MonoBehaviour
{
    public static TouchControll instance;
    int stairsCount=1;
    int stairsLoopCount=0;
    float speed;
    float stairsAnimSpeed;
    
    
    private void Awake()
    {
        instance = this;
       

    }
    
    void Update()
    {
        speed = PlayerPrefs.GetFloat("Speed");
        stairsAnimSpeed =0.2f/ (0.6f / speed);
        if (Input.touchCount > 0 && UIController.instance.gameStart == true)
        {
            touchedFinger();     

        }
        
        
    }
    void touchedFinger()
    {
        Touch touchFinger = Input.GetTouch(0);


            if (touchFinger.phase == TouchPhase.Began && PlayerControll.instance.climping == false && UIController.instance.gameStart == true)
            {
            if (PlayerControll.instance.oneStep)
            {
                CharacterClimp();
                FirstStairs();
                PlayerControll.instance.AnimStart();

            }
            }
        if (touchFinger.phase == TouchPhase.Began)
        {
            InvokeRepeating("TouchContinuos", speed, speed);
        }
        if (touchFinger.phase == TouchPhase.Ended )
        {
            CancelInvoke("TouchContinuos");
            PlayerControll.instance.AnimStopContinuos();
           
        }


    }
    
    void TouchContinuos()
    {
        
        CharacterClimp();
        FirstStairs();
        PlayerControll.instance.AnimStartContinuos();
        

    }
    
    void CharacterClimp()
    {
        Stamina.instance.StaminaDecrease();        
        PlayerControll.instance.PlayerClimp(StairsControll.instance.stairs[stairsCount - 1].transform.position, StairsControll.instance.stairs[stairsCount].transform.position, stairsCount);
       
    }
    void FirstStairs()
    {
        Money.instance.MoneyIncrease();
        StairsControll.instance.StairsActiveAnim(stairsCount);
        stairsCount++;
        
        HeightIndicator.instance.ScoreIndicatorHight();
        StairsLoopControll();
        Invoke("SecondStairs", stairsAnimSpeed);
        
    }
    void SecondStairs()
    {
        Money.instance.MoneyIncrease();
        StairsControll.instance.StairsActiveAnim(stairsCount);
        stairsCount++;
        
        HeightIndicator.instance.ScoreIndicatorHight();
        StairsLoopControll();
    }
    void StairsLoopControll()
    {
        if (stairsCount == 48)
        {
            stairsCount = 0;
            stairsLoopCount++;
        }
        StairsControll.instance.StairsChangePosition(stairsCount, stairsLoopCount);
    }
    public void HightScoreCount()
    {
        if(PlayerPrefs.GetInt("StairCount")< ((stairsLoopCount * 47) + stairsCount))
        {
            PlayerPrefs.SetInt("StairCount", (stairsLoopCount * 47) + stairsCount);

        }
    }
    
   

    
}
