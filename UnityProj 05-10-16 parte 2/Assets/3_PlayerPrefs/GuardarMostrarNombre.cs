using UnityEngine;
using UnityEngine.UI;

public class GuardarMostrarNombre : MonoBehaviour
{
	public Text textFieldDelNombre;

	private const string key = "nombre";

	void Start ()
	{
		if (PlayerPrefs.HasKey (key))
		{
			SetearNombreEnCampoDeBienvenida (PlayerPrefs.GetString (key));
		}
	}

	public void GuardarNombre(string nombreIngresado)
	{
		PlayerPrefs.SetString (key, nombreIngresado);

		SetearNombreEnCampoDeBienvenida (nombreIngresado);
	}

	private void SetearNombreEnCampoDeBienvenida(string nombre)
	{
		textFieldDelNombre.text = "Bienvenido " + nombre + "!";
	}
}
