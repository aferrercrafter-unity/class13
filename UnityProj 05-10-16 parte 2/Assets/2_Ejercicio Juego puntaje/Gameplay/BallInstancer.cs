using UnityEngine;

public class BallInstancer : MonoBehaviour
{
	public GameObject prefab;
	public float timeBetweenInstances;

	void Start()
	{
		InvokeRepeating ("CreateBall", 0f, timeBetweenInstances);
	}

	void CreateBall()
	{
		Vector3 initPos = new Vector3 (Random.Range (-5f, 5f), 7f, 0f);
		Instantiate (prefab, initPos, Quaternion.identity);
	}
}
