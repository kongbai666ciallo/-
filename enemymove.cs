using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class enemymove : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public int HP = 100;
    public Transform player;
    public NavMeshAgent agent;
    private float attackCD=0.5f;
    private float attackTimer;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,player.position)<=10)
        {
            agent.isStopped = false;
            if(Time.time-attackTimer>=attackCD)
            {
                animator.SetTrigger("attack");
            }
        }
        else
        {
            agent.isStopped = false;
            agent.SetDestination(player.position);
        }
    }
    public void TakeDamage(int attackValue)
    {
        HP -= attackValue;
        if(HP <= 0)
        {
            animator.SetBool("die",true);
        }
    }
 
}
