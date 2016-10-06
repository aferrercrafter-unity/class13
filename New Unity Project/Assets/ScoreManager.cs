using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {
	public int score = 0;
	public float time;
	public Vector3 runner_position = new Vector3(0.0f, 1.0f, 0.0f);
	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (this.gameObject);
		if(GameObject.FindGameObjectsWithTag ("Score").Length > 1)
			Destroy(this.gameObject);
		if (time == 0.0f) {
			score = 0;
		}
			
			
	}

	public void RunnerPosition(Vector3 xPosition){
		runner_position = xPosition;
		time += Time.deltaTime;
		score = (int)time;
	}

	public void ResetScore(){
		time = 0.0f;
		runner_position = new Vector3(0.0f, 1.0f, 0.0f);
	}
}
