using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameoverScript : MonoBehaviour {
    public static bool gameover = false;

    public void Retry()
    {
        gameover = false;
        ScoreCount.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("retry button pressed");


    }
}
