using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFllow : MonoBehaviour {

    public Animator animator;
    private CharacterController Soldier_Controller_RootMotion;
    float speed = 1;
    void Start()
    {
       Soldier_Controller_RootMotion = GetComponent<CharacterController>();
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
            float horizontal = Input.GetAxis("Horizontal");
            animator.SetTrigger("walk");
            float vertical = Input.GetAxis("Vertical");
            Vector3 dir1 = new Vector3(horizontal,0,vertical);
            Soldier_Controller_RootMotion.SimpleMove(dir1*10);
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            animator.ResetTrigger("walk");
        }
        if(Input.GetKey(KeyCode.S))
        {
            float horizontal = Input.GetAxis("Horizontal");
            animator.SetTrigger("houtui");
            float vertical = Input.GetAxis("Vertical");
            Vector3 dir1 = new Vector3(horizontal,0,vertical);
            Soldier_Controller_RootMotion.SimpleMove(dir1*10);
        }
        if(Input.GetKeyUp(KeyCode.S))
        {
            animator.ResetTrigger("houtui");

        }
        if(Input.GetKey(KeyCode.A))
        {
            float horizontal = Input.GetAxis("Horizontal");
            animator.SetTrigger("walk");
            float vertical = Input.GetAxis("Vertical");
            Vector3 dir1 = new Vector3(horizontal,0,vertical);
            Soldier_Controller_RootMotion.SimpleMove(dir1*10);
        }
        if(Input.GetKeyUp(KeyCode.A))
        {
            animator.ResetTrigger("walk");
        }
        if(Input.GetKey(KeyCode.D))
        {
            float horizontal = Input.GetAxis("Horizontal");
            animator.SetTrigger("houtui");
            float vertical = Input.GetAxis("Vertical");
            Vector3 dir1 = new Vector3(horizontal,0,vertical);
            Soldier_Controller_RootMotion.SimpleMove(dir1*10);
        }
        if(Input.GetKeyUp(KeyCode.D))
        {
            animator.ResetTrigger("houtui");

        }
    }

}

