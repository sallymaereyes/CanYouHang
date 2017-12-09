using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeObjects : MonoBehaviour {

    public GameObject capsule; //capsule
	public GameObject sphere;
	public GameObject cube;
	int num = 0;

	List<GameObject> prefabList = new List<GameObject>();
	// Use this for initialization
	void Start () {
		prefabList.Add(capsule);
		prefabList.Add(sphere);
		prefabList.Add(cube);
		prefabList[num].SetActive(true); 
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
			num--;
			if (num < 0) {
				prefabList [0].SetActive (false);
				prefabList [2].SetActive (true);
				num = 2;
			}
			else {
				prefabList [num + 1].SetActive (false);
				prefabList [num].SetActive (true);
			}
 //           Debug.Log("capsule changes left");
        }
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			num++;
			if (num > 2) {
				prefabList [2].SetActive (false);
				prefabList [0].SetActive (true);
				num = 0;
			}
			else {
				prefabList [num - 1].SetActive (false);
				prefabList [num].SetActive (true);
			}
		}
    }
}
