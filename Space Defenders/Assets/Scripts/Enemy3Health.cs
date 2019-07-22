using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy3Health : MonoBehaviour
{
    public int enemy3MaxHealth;
    public int enemy3CurrentHealth;
    public Text healthText;


    // Start is called before the first frame update
    void Start()
    {
        enemy3CurrentHealth = enemy3MaxHealth;
        healthText.text = "Enemy Health: " + enemy3CurrentHealth;

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Enemy Health: " + enemy3CurrentHealth;
        if (enemy3CurrentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Level 4", LoadSceneMode.Single);
        }
    }
    public void HurtEnemy(int damageToGive)
    {
        enemy3CurrentHealth -= damageToGive;

    }
    public void SetMaxHealth()
    {
        enemy3CurrentHealth = enemy3MaxHealth;
    }
}
