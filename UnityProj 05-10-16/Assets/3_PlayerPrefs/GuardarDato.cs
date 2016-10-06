using UnityEngine;

public class GuardarDato : MonoBehaviour
{
	void Start () {

		// guardar
		PlayerPrefs.SetString ("nombre_jugador", "Sergio");

		// leer
		string nombre = PlayerPrefs.GetString ("nombre_jugador");

		// chequear
		PlayerPrefs.HasKey ("nombre_jugador");
	}
}
