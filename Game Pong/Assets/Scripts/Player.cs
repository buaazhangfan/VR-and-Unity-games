﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 20f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float inputSpeed = Input.GetAxisRaw("Player");
		transform.position += new Vector3(0f, 0f, inputSpeed * speed * Time.deltaTime);
		
	}
}
