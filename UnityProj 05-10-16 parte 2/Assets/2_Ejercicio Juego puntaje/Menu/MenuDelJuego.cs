using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuDelJuego : MonoBehaviour
{
	public Text scoreText;

	void Start ()
	{
		scoreText.text = "Ultimo puntaje: " + ScoreSystem.score.ToString();
	}

	public void CargarJuego()
	{
		ScoreSystem.score = 0;

		SceneManager.LoadScene("Juego");
	}
}