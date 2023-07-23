using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public bool hasHealth;
    public HealthBar healthBar;

    void Start()
    {
        if(hasHealth) {
            currentHealth = maxHealth;
            healthBar.setMaxHealth(maxHealth);
        }
    }

    void Update()
    {
        
    }

    void takeDamage(int damage) {
        if(hasHealth) {
            currentHealth -= damage;
            healthBar.setHealth(currentHealth);
        } else {
            Debug.LogWarning("This object cannot take damage, because it doesn't have health.");
        }
    }
}
