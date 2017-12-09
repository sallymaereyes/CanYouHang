using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
    public Transform[] spawnPoints;

	List<GameObject> prefabList = new List<GameObject>();

    public GameObject prefabObject;
	public GameObject beer;
	public GameObject wine;

    private float timeToSpawn = 1f;
    private float timeBetweenWaves = 2f;

    // Use this for initialization
    void Start () {
		prefabList.Add(prefabObject);
		prefabList.Add(beer);
		prefabList.Add(wine);
    }

    // Update is called once per frame
    void Update () {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }

    }
    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
		int prefabIndex = Random.Range(0,3);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
				Instantiate(prefabList[prefabIndex], spawnPoints[randomIndex].position, Quaternion.identity);                
            }
        }
    }
   

}
