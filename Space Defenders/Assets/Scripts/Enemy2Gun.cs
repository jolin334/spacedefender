using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Gun : MonoBehaviour
{
    public GameObject Enemy2Bullet;
    private Vector2 Enemy2BulletPosition;
    int timer2 = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer2++;
        if (timer2 == 75)
        {
            GameObject.Find("ShootSound").GetComponent<AudioSource>().Play();
            Enemy2BulletPosition = transform.position;
            Instantiate(Enemy2Bullet, Enemy2BulletPosition, Quaternion.identity);
            timer2 = 0;
        }
    }
}
