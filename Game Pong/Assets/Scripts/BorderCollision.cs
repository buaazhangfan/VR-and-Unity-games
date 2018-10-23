using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BorderCollision : MonoBehaviour {

	public ScoreUI score;


	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Puck")
		{
			col.gameObject.transform.position = new Vector3(0f, 1f, 0f);
			if (gameObject.tag == "PlayerGoal")
			{
				score.scorePlayerAI++;

			}
			if (gameObject.tag == "PlayerAIGoal")
			{
				score.scorePlayer++;
			}
		}
	}
}
