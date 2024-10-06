using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animatorController : MonoBehaviour {

    public Animator animator;
    public Transform gunPoint;
    public Transform player;
    public Text blood;
    public Text time;
    public int bloodnum = 100;
    int attackValue = 10;

    void Start()
    {

    }

    void Update()
    {

        if(Input.GetMouseButtonDown(1))
        {
            animator.SetTrigger("Aiming");
  
            
        }
        if(Input.GetMouseButtonUp(1))
        {
            animator.ResetTrigger("Aiming");

        }
        if(Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("walk");
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            animator.ResetTrigger("walk");
        }
        if(Input.GetKey(KeyCode.S))
        {
            animator.SetTrigger("houtui");
        }
        if(Input.GetKeyUp(KeyCode.S))
        {
            animator.ResetTrigger("houtui");

        }
        if(Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger("left");
        }
        if(Input.GetKeyUp(KeyCode.A))
        {
            animator.ResetTrigger("left");
        }
        if(Input.GetKey(KeyCode.D))
        {
            animator.SetTrigger("right");
        }
        if(Input.GetKeyUp(KeyCode.D))
        {
            animator.ResetTrigger("right");

        }
        Atack();
        diaoxue();
        time.text = "time"+DateTime.Now.ToString();
    }
    private void Atack()
    {
        if(Input.GetMouseButton(0))
        {
            
            RaycastHit hit;
            if(Physics.Raycast(gunPoint.position,gunPoint.forward,out hit,100))
            {
                if(hit.collider.CompareTag("enemy"))
                {
                    hit.transform.GetComponent<enemymove>().TakeDamage(attackValue);
                }
            }
        }
    }
    public void diaoxue()
    {
        if(Vector3.Distance(transform.position,player.position)<=2)
        {
            bloodnum -=10;
            blood.text = "blood:"+bloodnum.ToString();
            if(bloodnum<=0)
            {
                blood.text = "gameover";
            }
        }
    }
}
        



