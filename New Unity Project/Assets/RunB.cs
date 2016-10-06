using UnityEngine;
using System.Collections;

public class RunB : MonoBehaviour {

	public float speed;

	float horizontal_mov;
	float vertical_mov;
	Rigidbody rb;

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate(){

		horizontal_mov = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		vertical_mov = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
		rb.AddForce (Vector3.right * horizontal_mov);
		rb.AddForce (Vector3.forward * vertical_mov);
	}

	void OnTriggerEnter(Collider col){
		Destroy (col.gameObject);
		Vector3 position = transform.position;
		rb.AddForce(Vector3.back * -10, ForceMode.Impulse);
	}
}
