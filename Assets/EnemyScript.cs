using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    // public GameObject _healthbar;
    [SerializeField] private float _maxHealth;
    private float currentHealth;
    [SerializeField] private Image _healthbarSprite;
    public GameObject enemy;
    public GameObject player;
    // public Transform changePos;
    // public bool lvl1Completed = false;
    // public GameObject objA;
    void Start()
    {
        currentHealth=_maxHealth;
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth<=0){
            animator.SetBool("isAttacking",false);
            // Debug.Log(enemy.tag);
            
            if(enemy.tag=="Enemy1_3"){
                float targetX=51.03f;
                float targetY=-0.05f;
                float targetZ=35.43f;
                if (player != null)
                {
                    // Debug.Log("Player found");
                    // Debug.Log(player.transform.position);
                    // Vector3 temp = new Vector3(targetX, targetY, targetZ);
                    // Debug.Log(temp);
                    // lvl1Completed = true;
                    //player.transform = changePos;
                    player.transform.position = new Vector3(targetX, targetY, targetZ);
                    //player.transform.Translate(new Vector3(targetX, targetY, targetZ));
                }
                else
                {
                    Debug.LogError("Player not found");
                }
            }
            DestroyObjectDelayed();
        }
        else{
            _healthbarSprite.fillAmount=currentHealth/_maxHealth;   
        }
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag=="sword"){
            
            currentHealth-=6;
        }
    }
    void DestroyObjectDelayed()
    {
        // Destroy the GameObject this script is attached to
        Destroy(enemy);
    }
}
