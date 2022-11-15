using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 4;
    public int currentHealth;

    public HealthBar healthBar;

    public GameOverScreen GameOverScreen;

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
        
        if (currentHealth <= 0) {
            GameOver();
            gameObject.SetActive(false);
        }
    }

    void TakeDamage(int damage) {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        ZeldaHealthBar.instance.RemoveHearts(damage);
    }

    public void GameOver() {
        GameOverScreen.SetUp();
    }
}
