using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {
	
	[SerializeField]
	private TextMesh _scoreUI;

	public static double score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
			Debug.Log (score);
			_scoreUI.text = "Score: \n" + score;
    }
}
