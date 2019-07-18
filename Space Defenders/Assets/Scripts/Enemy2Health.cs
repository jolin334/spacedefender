using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy2Health : MonoBehaviour
{
    public int enemy2MaxHealth;
    public int enemy2CurrentHealth;
    public Text healthText;


    // Start is called before the first frame update
    void Start()
    {
        enemy2CurrentHealth = enemy2MaxHealth;
        healthText.text = "Health: " + enemy2CurrentHealth;

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + enemy2CurrentHealth;
        if (enemy2CurrentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Level 3", LoadSceneMode.Single);
        }
    }
    public void HurtEnemy(int damageToGive)
    {
        enemy2CurrentHealth -= damageToGive;

    }
    public void SetMaxHealth()
    {
        enemy2CurrentHealth = enemy2MaxHealth;
    }
}
