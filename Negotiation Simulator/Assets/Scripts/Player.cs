using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 10; 
    public int currentHealth;
    public int totalpoints;

    public HealthBar healthbar;


    void Start()
    {
        totalpoints = 0;
        currentHealth = maxHealth / 2;
        healthbar.SetMaxHealth(maxHealth);
        healthbar.SetHealth(currentHealth);
    }

    void Update()
    {
        // condition for losing health
        // TakeDamage(1);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
    }
}
