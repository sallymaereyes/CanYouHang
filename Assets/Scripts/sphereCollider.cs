﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "sphere")
        {
			ScoreCount.score = ScoreCount.score + .5;
            Debug.Log("sphere collision hit");
            //count = count++;
            //scoreLabel.text = "Score" + count;
            Destroy(collision.gameObject);
        }
    }
}
