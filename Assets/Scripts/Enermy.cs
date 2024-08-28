using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    protected Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }
    private void Move()
    {
        rb.velocity = Vector2.down * moveSpeed;
    }
}
