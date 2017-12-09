using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
	
    public float speed = 2f;
    public GameObject target;
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
	}
   

}
