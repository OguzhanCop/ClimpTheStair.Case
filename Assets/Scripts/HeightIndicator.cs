using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class HeightIndicator : MonoBehaviour
{
    public static HeightIndicator instance;
    public GameObject cylinderWood;
    GameObject cylinderWoodClone;
    TextMeshPro scoreText;
    int scoreMajor = -500;
    int scoreMinor = 0;
    bool scorePositive = false;
    float scoreDiff = 40.8f;


    public void Awake()
    {
        instance = this;
        scoreText = transform.GetChild(0).gameObject.GetComponent<TextMeshPro>();
       
    }
    public void Update()
    {
       
        PlaneSetPos();
    }

    public void ScoreIndicatorHight()
    {
        CylinderHeight();
        transform.Translate(0, 0.078f, 0);
        ScoreIndicator();     
        
        
    }
    public void CylinderHeight()
    {
        Vector3 posDiff = new Vector3(transform.position.x, transform.position.y - 0.119f, transform.position.z);
        cylinderWoodClone = Instantiate(cylinderWood, posDiff, Quaternion.identity);
        cylinderWoodClone.transform.DOScale(new Vector3(1, 0.545f, 1), 0.2f);

    }
    public void PlaneSetPos()
    {
        if (scoreMajor-(-500) >= scoreDiff)
        {
            PlaneControll.instance.ChangePlanePos();            
            scoreDiff += 27.6f;            
        }
    }
    void ScoreIndicator()
    {
        if (scoreMajor > 0)
        {
            scoreMinor += 4;
            if (scoreMinor >= 10)
            {
                scoreMajor++;
                scoreMinor = scoreMinor % 10;
            }

        }
        else if (scoreMajor == 0)
        {
            if (scorePositive)
            {
                scoreMinor += 4;
                if (scoreMinor >= 10)
                {
                    scoreMajor++;
                    scoreMinor = scoreMinor % 10;
                }
            }
            else
            {
                if (scoreMinor - 4 < 0)
                {
                    scoreMinor = 4 - scoreMinor;
                    scorePositive = true;
                }
                else
                {
                    scoreMinor -= 4;
                }
            }
        }
        else if (scoreMajor < 0)
        {
            if (scoreMinor - 4 < 0)
            {
                scoreMinor += 10;
                scoreMajor++;
                scoreMinor -= 4;
            }
            else
            {
                scoreMinor -= 4;
            }
        }
       
        scoreText.text = scoreMajor+"."+scoreMinor + "m";
    }
    public void HighScore()
    {       
       
        if (PlayerPrefs.GetInt("ScoreMajor") < scoreMajor)
        {           
            PlayerPrefs.SetInt("ScoreMajor", scoreMajor);
            PlayerPrefs.SetInt("ScoreMinor", scoreMinor);
        }
       
    }
}
