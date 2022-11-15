using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 4;
    public int currentHealth;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        ZeldaHealthBar.instance.SetUpHearts(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            TakeDamage(1);
        }
    }

    void TakeDamage(int damage) {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        ZeldaHealthBar.instance.RemoveHearts(damage);
    }
}
