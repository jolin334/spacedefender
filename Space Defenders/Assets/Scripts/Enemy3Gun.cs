using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Gun : MonoBehaviour
{
    public GameObject Enemy3Bullet;
    private Vector2 Enemy3BulletPosition;
    int timer3 = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer3++;
        if (timer3 == 50)
        {
            GameObject.Find("ShootSound").GetComponent<AudioSource>().Play();
            Enemy3BulletPosition = transform.position;
            Instantiate(Enemy3Bullet, Enemy3BulletPosition, Quaternion.identity);
            timer3 = 0;
        }
    }
}
