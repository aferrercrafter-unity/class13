using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate(){
		if (this.gameObject.transform.position.y < 0)
			Destroy (this.gameObject);
	}
}
