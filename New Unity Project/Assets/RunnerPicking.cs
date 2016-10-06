using UnityEngine;
using System.Collections;

public class RunnerPicking : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){
		Destroy (col.gameObject);
		Vector3 position = transform.position;
		this.transform.Translate (new Vector3 (-10, 0.0f, 0.0f));
	}
}
