using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : MonoBehaviour
{
    Animator animator;
    public NavMeshAgent enemy;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance=Vector3.Distance(player.position,animator.transform.position);
        if(distance<10){
            enemy.SetDestination(player.position);
            animator.SetBool("isWalking",true); 
        }
        
        else{
            animator.SetBool("isWalking",false); 
            animator.SetBool("isAttacking",false); 
            
        }
        if(distance<4){
            animator.SetBool("isAttacking",true); 
            animator.SetBool("isWalking",false); 
        }
        
    }
}
