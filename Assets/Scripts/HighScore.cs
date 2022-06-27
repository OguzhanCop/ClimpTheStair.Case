using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    TextMeshPro scoreText;
    public GameObject wood;
    private void Awake()
    {
        scoreText = transform.GetChild(0).gameObject.GetComponent<TextMeshPro>();
        
    }
    private void Update()
    {
        transform.position = new Vector3(-0.740f, 0.078f * PlayerPrefs.GetInt("StairCount"), -0.987f);
        scoreText.text = PlayerPrefs.GetInt("ScoreMajor") + "." + PlayerPrefs.GetInt("ScoreMinor") + "m";
        wood.transform.position = transform.position+new Vector3(0, -0.155f,0);
    }

}
