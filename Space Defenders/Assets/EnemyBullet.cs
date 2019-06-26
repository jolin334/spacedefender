using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    float speed;
    Vector3 direction; //the direction of the bullet
    bool isReady;
    private void Awake()
    {
        speed = 5f;
        isReady = false;

    }
    // Start is called before the first frame update
    void Start()
    {

    }
    public void SetDirection(Vector3 direction)
    {
        direction = direction.normalized;
        isReady = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (isReady)
        {
            Vector3 position = transform.position;
            position += direction * speed * Time.deltaTime;
            transform.position = position;
            Vector3 min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
            Vector3 max = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
            if ((transform.position.x < min.x) || (transform.position.x > max.x) ||
               (transform.position.y < min.y) || (transform.position.y > max.y)) {
                Destroy(gameObject);
            }
        }
    }
}
