using UnityEngine;
using UnityEngine.UI;

public class PadScore : MonoBehaviour {

	public Text scoreText;

	void OnCollisionEnter (Collision col)
	{
		ScoreSystem.score++;

		scoreText.text = "Puntos: " + ScoreSystem.score.ToString ();;
	}
}
