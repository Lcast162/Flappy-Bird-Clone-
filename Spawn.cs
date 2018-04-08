using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{

	public float range;

	// Use this for initialization


	// Use this for initialization
	void Start ()
	{
		range = Random.Range(-2.0f,2.0f);
	}

	// Update is called once per frame
	void Update ()
	{

		transform.position = new Vector3(transform.position.x, range, transform.position.z);
		Destroy (this);
		Destroy (gameObject, 5);
}
}

