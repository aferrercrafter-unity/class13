using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Manager : MonoBehaviour {

	public GameObject runner;
	public GameObject prefab;
	ScoreManager score;
	public Text scoreUI;

	// Use this for initialization
	void Awake () {
		score = GameObject.FindGameObjectWithTag ("Score").GetComponent<ScoreManager> ();
		print (score.time);
		runner.transform.position = score.runner_position;
		InvokeRepeating ("Spawn", 0.0f ,0.2f);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void LateUpdate(){
		score.RunnerPosition(runner.transform.position);
		scoreUI.text = "Score: " + score.score;

		if (runner.transform.position.y < -1) {
			score.ResetScore ();
			SceneManager.LoadScene ("Menu");
		}
			
	}

	public void Menu(){
		SceneManager.LoadScene ("Menu");
	}

	public void Spawn(){
		float x = Random.Range (-10.0f, 10.0f);
		float z = Random.Range (-10.0f, 10.0f);
		Instantiate (prefab, new Vector3(x, 10.0f, z), Quaternion.identity);
	}
}
