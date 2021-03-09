using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    [SerializeField]  Transform ball;
    [SerializeField]  float speed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.GetComponent<Ball>().gameStarted)
        {
            if (transform.position.y < ball.position.y)
            {
                transform.position =
                    new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
            }else if (transform.position.y > ball.position.y)
            {
                transform.position =
                    new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
            }
        }
    }

  
}
