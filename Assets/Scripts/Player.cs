using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] protected Vector3 worldPositon;
    [SerializeField] protected float speed;

    [SerializeField] protected GameObject Bullet;
    [SerializeField] protected GameObject Enermy;
    public Transform shoottingPoint;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }   
    }
    private void FixedUpdate()
    {
        this.worldPositon = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.worldPositon.z = 0;
        Vector3 newPos = Vector3.Lerp(transform.position, worldPositon, speed);
        transform.position = newPos;




    }
    private void Shoot()
    {
        if(Bullet && shoottingPoint)
        {
            Instantiate(Bullet, shoottingPoint.position, Quaternion.Euler(0,0,90));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enermy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
