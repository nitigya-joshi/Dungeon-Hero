using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthScript : MonoBehaviour
{
    [SerializeField] private Image _healthbarSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateHealthBar(float maxHealth,float currentHealth){
        Debug.Log("hello");
        _healthbarSprite.fillAmount=currentHealth/maxHealth;
    }
}
