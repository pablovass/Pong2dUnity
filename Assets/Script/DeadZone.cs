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
    [SerializeField]  SceneChanger sceneChanger;
    [SerializeField]  AudioSource ballAudio;
    int scorePlayerQuantity;
    int scoreEnemyQuantity;
    
    //detecta cuando atravieza la colicion
    private void OnTriggerEnter2D(Collider2D ball)
    {
        if (gameObject.tag == "Left")
        {
            scoreEnemyQuantity++;
            UpdateScoreLabel(scoreEnemy,scoreEnemyQuantity);
            ballAudio.Play();
        }else if (gameObject.tag == "Right")
        {
            scorePlayerQuantity++;
            UpdateScoreLabel(scorePlayer,scorePlayerQuantity);
            ballAudio.Play();
        }

        ball.GetComponent<Ball>().gameStarted = false;
        CheackScore();
    }

    void CheackScore()
    {
        if (scorePlayerQuantity >= 3)
        {
          sceneChanger.ChangeSceneTo("WinScene");  
        } else if (scoreEnemyQuantity>=3)
        {
            sceneChanger.ChangeSceneTo("LoseScene");
        }
    }
    void UpdateScoreLabel(Text label, int score)
    {
        label.text = score.ToString();
    }
}
