using UnityEngine;

public class Ball : MonoBehaviour
{
	void OnCollisionEnter (Collision col)
	{
		Destroy (gameObject);
	}
}
