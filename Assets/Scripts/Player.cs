using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] protected Vector3 worldPositon;
    [SerializeField] protected float speed = 0.3f;
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    private void FixedUpdate()
    {
        this.worldPositon = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.worldPositon.z = 0;
        Vector3 newPos = Vector3.Lerp(transform.position, worldPositon, speed);
        transform.position = newPos;


    }

}
