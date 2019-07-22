using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalEnemyHealth : MonoBehaviour
{
    public int finalenemyMaxHealth;
    public int finalenemyCurrentHealth;
    public Text healthText;
    private PlayerHealth playerHealth;


    // Start is called before the first frame update
    void Start()
    {
        finalenemyCurrentHealth = finalenemyMaxHealth;
        healthText.text = "Enemy Health: " + finalenemyCurrentHealth;
        playerHealth = GameObject.Find("Player").GetComponent<PlayerHealth>();

    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Enemy Health: " + finalenemyCurrentHealth;
        if (finalenemyCurrentHealth <= 0 && playerHealth.playerCurrentHealth <100)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("You Win", LoadSceneMode.Single);
            GameObject.Find("WinSound").GetComponent<AudioSource>().Play();

        } else if(finalenemyCurrentHealth <= 0 && playerHealth.playerCurrentHealth > 99)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Secret Level", LoadSceneMode.Single);
        }
    }
    public void HurtEnemy(int damageToGive)
    {
        finalenemyCurrentHealth -= damageToGive;

    }
    public void SetMaxHealth()
    {
        finalenemyCurrentHealth = finalenemyMaxHealth;
    }
}
