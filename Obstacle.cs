using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
	public Vector2 velocity;




	void Start ()
	{
		
	
		velocity = new Vector2 (-10f, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		


			transform.Translate (velocity * Time.deltaTime);
		
	}

}


