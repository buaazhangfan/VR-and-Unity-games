using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	public int band;
	public float startScale;
	public float scaleMultiplier;
	public GameObject cube;
	// Use this for initialization
	void Start () {
		startScale = 1;
		scaleMultiplier = 30;
		string name = cube.name;
		band = int.Parse(name);
	}
	
	// Update is called once per frame
	void Update () {

		float level = SpectrumAnalyzer.audioBands[band];
		//print(level);
		float height = level * scaleMultiplier + startScale;
		cube.transform.localScale = new Vector3(1.0F, height, 1.0F);
	}
}
