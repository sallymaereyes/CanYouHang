﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeCollider : MonoBehaviour {
    public GameObject gameoverMenu;

    // Use this for initialization
    void Start() {

    }

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "cube")
        {
            ScoreCount.score = ScoreCount.score + .5;
            Debug.Log("cube collision hit");
            //count = count++;
            //scoreLabel.text = "Score" + count;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "sphere")
        {
            GameOver();

        }
        else if (collision.gameObject.tag == "capsule")
        {
            GameOver();

        }
        
    }
    public void GameOver()
    {
        if (!gameoverScript.gameover)
        {
            gameoverScript.gameover = true;
            gameoverMenu.SetActive(true);
            Debug.Log("gameover");

        }
    }

}