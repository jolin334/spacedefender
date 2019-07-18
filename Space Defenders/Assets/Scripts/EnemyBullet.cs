using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    private Transform target;
    public float speed;
    Vector2 pos;
    public int damageToGive;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        transform.position = Vector2.MoveTowards(transform.position,
        target.position, speed * Time.deltaTime);
        pos = target.position;
    }

    private void Update()
    {
        rb.velocity = new Vector2(pos.x * speed, pos.y * speed);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerHealth>().HurtPlayer(damageToGive);
            Destroy(gameObject);
        }
    }
}
