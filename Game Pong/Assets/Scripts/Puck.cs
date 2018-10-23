using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour {

	public Vector3 initialImpluse;
	public Rigidbody rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.AddForce(initialImpluse, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
