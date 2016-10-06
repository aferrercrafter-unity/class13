using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayDelJuego : MonoBehaviour
{
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape))
		{
			SceneManager.LoadScene("MenuDelJuego");
		}
	}
}
