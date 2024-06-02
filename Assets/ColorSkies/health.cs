using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public Animator
    void Start()
    {
        currentHealth = 1;
    }
    void TakeDamage(int amount)
    {
        currentHealth-=amount;
        if (currentHealth <= 0)
        { 
            anim.SetBool("IsDead", true); 
        }
        void Heal(int amount)
        {
            currentHealth += amount;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }


        }
    }

