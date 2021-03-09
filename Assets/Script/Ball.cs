using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Transform paddle;
    [SerializeField]  Rigidbody2D rbBall;
    [SerializeField] private AudioSource ballAudio;
    public bool gameStarted = false; // public por que nesesitamos acceder desde otra clase
     float posDif = 0;
    
    // Start is called before the first frame update
    void Start()
    {
       posDif = paddle.position.x - transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
         
           
            transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);
            
            if (Input.GetMouseButtonDown(0))
            {
                rbBall.velocity = new Vector2(8, 8);
                gameStarted = true;
            }
   
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    { 
        // crear un condicional para que solo suene cuando golpee contra el auto
        ballAudio.Play();
    }
}
