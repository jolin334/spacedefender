using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int playerMaxHealth;
    public int playerCurrentHealth;
    public Text healthText;
    Animator anim;
    int zero = 0;

    // Start is called before the first frame update
    void Start()
    {
        playerCurrentHealth = playerMaxHealth;

        healthText.text = "Player Health: " + playerCurrentHealth;
        anim = GetComponent<Animator>();
         
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Player Health: " + playerCurrentHealth;
        if (playerCurrentHealth < 1)
        {
            playSound(zero);
            zero++;
            anim.SetBool("isExplode", true);
            StartCoroutine(WaitToDie());
        }
    }

void playSound(int zero)
    {
        if (zero == 0)
        {
            GameObject.Find("ExplodeSound").GetComponent<AudioSource>().Play();
        }
    }

    public void HurtPlayer(int damageToGive)
{
    playerCurrentHealth -= damageToGive;
}


public void SetMaxHealth()
{
    playerCurrentHealth = playerMaxHealth;
}

IEnumerator WaitToDie()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.SetActive(false);
        SceneManager.LoadScene("Game Over", LoadSceneMode.Single);
    }

}
