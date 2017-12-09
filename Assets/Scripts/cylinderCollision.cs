using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderCollision : MonoBehaviour {
    private void Start()
    {
    }
   
    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("hit");

        if (collision.gameObject.tag == "square")
        {
            Destroy(collision.gameObject);
            Debug.Log("cylinder collision hit");
        }
    }
}
