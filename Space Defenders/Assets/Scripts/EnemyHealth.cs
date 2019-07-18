using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int enemyMaxHealth;
    public int enemyCurrentHealth;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
        healthText.text = "Health: " + enemyCurrentHealth;

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + enemyCurrentHealth;
        if (enemyCurrentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Level 2", LoadSceneMode.Single);
        }
    }
    public void HurtEnemy(int damageToGive)
    {
        enemyCurrentHealth -= damageToGive;

    }
    public void SetMaxHealth()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }
}
