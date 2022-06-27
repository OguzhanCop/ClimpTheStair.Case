using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

using TMPro;

public class StairsMoney : MonoBehaviour
{
    private void OnEnable()
    {
        transform.GetChild(0).GetComponent<TextMeshPro>().DOFade(0, 5f);
        transform.GetChild(0).GetComponent<TextMeshPro>().text = "$" +( 0.4f + (0.1f * PlayerPrefs.GetInt("IncomeLvl")));
    }

    
}
