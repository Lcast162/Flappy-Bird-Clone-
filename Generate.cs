using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour
{
	bool wait2;
	public GameObject rocks;
	// Use this for initialization
	void Start ()
	{
		wait2 = false;


			InvokeRepeating ("CreateObstacle", 1f, 2.0f);
		
	}
	

	void CreateObstacle ()
	{

		if (wait2) {
			Instantiate (rocks);                
		}
	}

	void Update()
	{
		if (Input.GetKeyUp ("space") || Input.GetMouseButtonUp (0)) {
			wait2 = true;
		}
	}
}

