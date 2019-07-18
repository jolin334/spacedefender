using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4Gun : MonoBehaviour
{
    public GameObject Enemy4Bullet;
    private Vector2 Enemy4BulletPosition;
    int timer4 = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer4++;
        if (timer4 == 25)
        {
            GameObject.Find("ShootSound").GetComponent<AudioSource>().Play();
            Enemy4BulletPosition = transform.position;
            Instantiate(Enemy4Bullet, Enemy4BulletPosition, Quaternion.identity);
            timer4 = 0;
        }
    }
}
