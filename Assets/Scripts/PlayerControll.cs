using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerControll : MonoBehaviour
{
    public static PlayerControll instance;
    Animator anim;
    public bool climping=false;
    public bool oneStep = true;
    float speed;


    private void Awake()
    {
        instance = this;
        anim = transform.GetComponent<Animator>();        
    }
    private void Update()
    {
        speed = PlayerPrefs.GetFloat("Speed");
        anim.speed = (0.6f / speed) * 1;
    }


    public void PlayerClimp(Vector3 pos, Vector3 pos2, int index)
    {
        climping = true;

        
        gameObject.transform.DORotateQuaternion(Quaternion.Euler(0, 90 + index * 15, 0), 0.6f);
        gameObject.transform.DOJump(pos + new Vector3(0, 0.04f, 0), 0.06f, 1,speed/2, false).OnComplete(() =>
            gameObject.transform.DOJump(pos2 + new Vector3(0, 0.04f, 0), 0.06f, 1, speed/2, false));

        //gameObject.transform.DOMove(pos + new Vector3(0, 0.04f, 0), speed/2, false).OnComplete(() =>                 // Alternative Move
        //gameObject.transform.DOMove(pos2 + new Vector3(0, 0.04f, 0), speed/2, false));


    }
    public void AnimStart()
    {
        Invoke("AnimStop", speed);
        climping = true;
        anim.SetBool("climp", true);
        oneStep = false;
        
    }
    public void AnimStop()
    {
       
        anim.SetBool("climp",false);        
        oneStep = true;
        climping = false;

    }
    public void AnimStartContinuos()
    {
        climping = true;
        anim.SetBool("climp", true);
    }
    public void AnimStopContinuos()
    {
       
        anim.SetBool("climp", false);
        climping = false;
    }
    
}
