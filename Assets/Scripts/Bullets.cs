using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    protected Rigidbody2D rb;
    [SerializeField] private float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.up * bulletSpeed;
        Destroy(gameObject,3);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enermy"))
        {
            Debug.Log("Bullet da cham Enermy");
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
