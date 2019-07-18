using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject EnemyBullet;
    private Vector2 EnemyBulletPosition;
    int timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer == 100)
        {
            GameObject.Find("ShootSound").GetComponent<AudioSource>().Play();
            EnemyBulletPosition = transform.position;
            Instantiate(EnemyBullet, EnemyBulletPosition, Quaternion.identity);
            timer = 0;
        }
    }
}
