using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerAnimationController : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    int isWalkingHash;
    private Vector3 initialPosition;
    public GameObject _healthbar;
    [SerializeField] private float _maxHealth;
    private float currentHealth;
    public GameObject player;
    public GameObject Enemy1_3;
    void Start()
    {
        animator=GetComponent<Animator>();
        isWalkingHash=Animator.StringToHash("isWalking");
        currentHealth=_maxHealth;
        //_healthbar.updateHealthBar(_maxHealth,currentHealth);
        // _healthbar.GetComponent<HealthBar>().updateHealthBar(_maxHealth,currentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed=Input.GetKey("w");
        bool takeHealth=Input.GetKey("e");

        bool isWalking=animator.GetBool("isWalking");
        bool attack=Input.GetKey("q");
        if(!isWalking&&forwardPressed){
            animator.SetBool("isWalking",true);
        }
        if(isWalking&&!forwardPressed){
            animator.SetBool("isWalking",false);
        }

        if(attack){
            animator.SetBool("isAttack",true);
        }
        if(!attack){
            animator.SetBool("isAttack",false);
        }
        if(takeHealth){
            currentHealth=_maxHealth;
        }
        // bool health=Input.GetKey("e");
        // if(health){
        //     currentHealth-=10;
        //     _healthbar.GetComponent<HealthBar>().updateHealthBar(_maxHealth,currentHealth);
        //     // Debug.Log(_maxHealth);
        //     // Debug.Log(currentHealth);
        // }
        // _healthbar.GetComponent<HealthBar>().updateHealthBar(_maxHealth,currentHealth);
        if(currentHealth<=0){
            animator.SetBool("isAttacking",false);
            DestroyObjectDelayed();
            Debug.Log("Destroyed2");
            ResetTheGame();
        }
        else{
            _healthbar.GetComponent<HealthBar>().updateHealthBar(_maxHealth,currentHealth);   
        }
        // if(Enemy1_3==null){
        //     Debug.Log("Done");
        //     float targetX=51.03f;
        //     float targetY=-0.05f;
        //     float targetZ=35.43f;
        //     transform.position=new Vector3(targetX, targetY, targetZ);
        // }
    }
    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag=="EnemyHand"){
            currentHealth-=5;
        }
    }
    void DestroyObjectDelayed()
    {
        // Destroy the GameObject this script is attached to
        Destroy(player);
    }
    public void ResetTheGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("The game is restart");
    }
}
