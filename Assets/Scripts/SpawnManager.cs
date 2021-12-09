using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public bool ebaleSpawn = false;
	public GameObject Enemy;
	void Start()
	{
		InvokeRepeating("SpawnEnemy", 3, 1);
	}

	// Update is called once per frame
	void Update()
	{

	}
	void SpawnEnemy()
	{
		float randomX = Random.Range(-5f, 1f);
		if (ebaleSpawn) 
		{
			GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(randomX, 1.1f, 0f), Quaternion.identity);
		}
	}
}
