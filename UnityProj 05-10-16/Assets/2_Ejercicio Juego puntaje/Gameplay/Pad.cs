using UnityEngine;

public class Pad : MonoBehaviour
{		
	public float speed;

	void Update ()
	{
		float h = Input.GetAxisRaw ("Horizontal");

		transform.Translate (Vector3.right * h * speed * Time.deltaTime);
	}
}
