using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
	public Transform[] spawnLocations;
	public float spawnTime;
	public GameObject monsterPrefab;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Spawn() {
		Transform spawn = spawnLocations[Random.Range(0, spawnLocations.Length)];
		GameObject monster = Instantiate(monsterPrefab, spawn.position, spawn.rotation);
	}
}
