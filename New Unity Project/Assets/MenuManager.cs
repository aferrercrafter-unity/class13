using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	ScoreManager score;
	public Text score_text;
	public Text user_text;

	void Awake(){

		score = GameObject.FindGameObjectWithTag ("Score").GetComponent<ScoreManager> ();
		score_text.text = "Score: " + score.score.ToString();

	}

	public void Play(){
		SceneManager.LoadScene ("Gameplay");
	}

	public void SaveUser(string user){
		user_text.text = "Usuario: " + user;
		
	}


}
