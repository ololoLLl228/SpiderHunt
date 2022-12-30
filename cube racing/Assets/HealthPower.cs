using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPower : MonoBehaviour
{
    public float health;
    public float maxHealth;
    [SerializeField] private Image bar;
    private float fill;
    [SerializeField] private Text text;
    private void Start()
    {
        fill = 1;
        maxHealth = health;
        bar.fillAmount = fill;
        text.text = health.ToString() + "/" + maxHealth.ToString();
    }
    public void  TakeHit(float damage)
    {
        health -= damage;
        if(health <= 0)
        {
            
            if (gameObject.tag == "Boss")
            {
                Animator animator = GetComponent<Animator>();
                animator.SetBool("isDead", true);
            }
        }
        fill = health / maxHealth;
        text.text = health.ToString() + "/" + maxHealth.ToString();
        bar.fillAmount = fill;
        
    }

    
    
}

