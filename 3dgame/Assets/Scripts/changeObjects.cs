using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeObjects : MonoBehaviour {

    public GameObject golfball;
	// Use this for initialization
	void Start () {
		
	}

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Instantiate(golfball, transform.position, transform.rotation);
            Debug.Log("change object");
        }
    }
}
