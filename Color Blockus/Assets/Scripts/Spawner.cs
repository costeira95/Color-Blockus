using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] spawnee;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
	
	// Update is called once per frame
	void Update () {
        if (timeBtwSpawn <= 0)
        {
            GameObject spawned = spawnee[Random.Range(0, spawnee.Length)];
            Instantiate(spawned, new Vector2(transform.position.x, spawned.transform.position.y), Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
            timeBtwSpawn -= Time.deltaTime;
	}
}
