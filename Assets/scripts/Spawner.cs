using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	//public float spawnTime = 5f;		// The amount of time between each spawn.
	//public float spawnDelay = 3f;		// The amount of time before spawning starts.
	public GameObject[] platform;		// Array of enemy prefabs.


	void Update ()
	{
		
	}


	void Spawn ()
	{
		// Instantiate a random enemy.
		//int enemyIndex = Random.Range(0, enemies.Length);
		//Instantiate(platform,GetComponent<Rigidbody2D>().position+10,transform.rotation);

	
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag=="ground") {
		//	GameObject.FindGameObjectWithTag("platform")
			
		}
	}
}
