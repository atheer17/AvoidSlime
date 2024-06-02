using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem
{
    private float healthPoints;
    private float maxHealth;

    public HealthSystem(int maxHealth)
    {
        this.maxHealth = maxHealth;
        healthPoints = maxHealth;
    }

    public float GetHealth()
    {
        return healthPoints;
    }

    public float GetHealthPercentage()
    {
        return (healthPoints / maxHealth) * 100f;
    }

    public void Damage(int damageAmount)
    {
        healthPoints -= damageAmount;
        if (healthPoints <= 0)
        {
            healthPoints = 0;
        }
    }

    public void Heal(int healAmount)
    {
        healthPoints += healAmount;
        if (healthPoints > maxHealth)
        {
            healthPoints = maxHealth;
        }
    }
}