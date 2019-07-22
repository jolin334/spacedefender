using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy4Health : MonoBehaviour
{
    public int enemy4MaxHealth;
    public int enemy4CurrentHealth;
    public Text healthText;


    // Start is called before the first frame update
    void Start()
    {
        enemy4CurrentHealth = enemy4MaxHealth;
        healthText.text = "Enemy Health: " + enemy4CurrentHealth;

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Enemy Health: " + enemy4CurrentHealth;
        if (enemy4CurrentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Final Level", LoadSceneMode.Single);
        }
    }
    public void HurtEnemy(int damageToGive)
    {
        enemy4CurrentHealth -= damageToGive;

    }
    public void SetMaxHealth()
    {
        enemy4CurrentHealth = enemy4MaxHealth;
    }
}
