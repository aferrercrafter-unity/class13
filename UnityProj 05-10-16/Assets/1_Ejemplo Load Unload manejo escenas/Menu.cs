using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	public void CargarJuego()
	{
//		SceneManager.LoadScene("Gameplay", LoadSceneMode.Additive);	

		SceneManager.LoadScene("Gameplay");
	}
}
