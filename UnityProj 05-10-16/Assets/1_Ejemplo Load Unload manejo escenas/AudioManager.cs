using UnityEngine;

public class AudioManager : MonoBehaviour {

	void Start ()
	{
		DontDestroyOnLoad(gameObject);


		AudioListener.volume = 0.0f;
	}
}
