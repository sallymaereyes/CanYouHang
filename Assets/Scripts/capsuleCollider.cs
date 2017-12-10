using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "capsule")
        {
            Debug.Log("capsule collision hit");
            //count = count++;
            //scoreLabel.text = "Score" + count;
            Destroy(collision.gameObject);
        }
    }
}
