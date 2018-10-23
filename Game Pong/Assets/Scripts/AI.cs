using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	public GameObject ball;
	public float speed = 15f;

	//private float e = 0.3f;

	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 ball_pos = ball.transform.position;
		Vector3 AI_pos = transform.position;
		float delta = ball_pos[2] - AI_pos[2];

		float alpha = Random.Range(0.0f, 1.0f);

		transform.position += new Vector3(0f, 0f, 0.08f * speed * delta * Time.deltaTime);

	}
}
