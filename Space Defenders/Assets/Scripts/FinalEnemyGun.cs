using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalEnemyGun : MonoBehaviour
{
    public GameObject finalEnemyBullet;
    public GameObject finalEnemyBullet2;
    private Vector2 finalEnemyBulletPosition;
    private Vector2 finalEnemyBulletPosition2;
    int timer5 = 0;
    int timer6 = 0;

    public Vector2 FinalEnemyBulletPosition2 { get => finalEnemyBulletPosition2; set => finalEnemyBulletPosition2 = value; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer6++;
        timer5++;
        if (timer5 == 50)
        {
            GameObject.Find("ShootSound").GetComponent<AudioSource>().Play();
            finalEnemyBulletPosition = transform.position;
            Instantiate(finalEnemyBullet, finalEnemyBulletPosition, Quaternion.identity);
            timer5 = 0;
        }
        if (timer6 == 500)
        {
            GameObject.Find("ShootSound").GetComponent<AudioSource>().Play();
            finalEnemyBulletPosition = transform.position;
            Instantiate(finalEnemyBullet2, FinalEnemyBulletPosition2, Quaternion.identity);
            timer6 = 0;
        }
    }
}
