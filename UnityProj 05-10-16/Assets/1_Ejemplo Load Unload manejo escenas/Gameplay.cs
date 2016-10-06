using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour 
{
	public void UnloadMenu()
	{
		SceneManager.UnloadScene("Menu");	
	}
}
