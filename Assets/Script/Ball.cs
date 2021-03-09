﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Transform paddle;
    [SerializeField]  Rigidbody2D rbBall;
    private bool gameStarted = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
         
            float posDif = paddle.position.x - transform.position.x;
            transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);
            
            if (Input.GetMouseButtonDown(0))
            {
                rbBall.velocity = new Vector2(8, 8);
                gameStarted = true;
            }
   
        }
    }
}