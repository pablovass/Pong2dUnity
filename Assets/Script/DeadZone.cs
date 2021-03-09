using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //carga esenas nuevas

public class DeadZone : MonoBehaviour
{
    //es el golpe
    private void OnCollisionEnter2D(Collision2D collision)
    {
        throw new NotImplementedException();
    }

    [SerializeField] Text scorePlayer;
    [SerializeField] Text scoreEnemy;
    int scorePlayerQuantity;
    int scoreEnemyQuantity;
    
    //detecta cuando atravieza la colicion
    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (gameObject.tag == "Left")
        {
            scoreEnemyQuantity++;
            UpdateScoreLabel(scoreEnemy,scoreEnemyQuantity);
        }else if (gameObject.tag == "Right")
        {
            scorePlayerQuantity++;
            UpdateScoreLabel(scorePlayer,scorePlayerQuantity);
        }
    }

    void UpdateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();
    }
}
