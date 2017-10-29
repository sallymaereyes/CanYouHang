using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TargetController : MonoBehaviour
{
    //public Text score;
    private int _score = 0;
    [SerializeField]
    public Text _scoreUI;
    private Transform _explosionSpawn;
    [SerializeField]
    private GameObject _explosionPrefab;

    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.tag.Equals("cannonball"))
        {
            _score++;
            Debug.Log("Score: " + _score);

        }

        _scoreUI.text = "Score: " + _score; // Displays the score
        
    }


}
