using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Image _healthbarSprite;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updateHealthBar(float maxHealth,float currentHealth){
        _healthbarSprite.fillAmount=currentHealth/maxHealth;
    }
}
