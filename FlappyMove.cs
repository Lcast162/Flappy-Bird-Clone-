using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FlappyMove : MonoBehaviour {
	
	int score=0;
	int jump=0;
	Rigidbody2D rb;
	Vector2 force;
	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
		rb.simulated = false;
		force=new Vector2(0,350);
	}
	void Die()
	{
		Application.LoadLevel ("Flappy");
	}

	// Update is called once per frame
	void Update () {
		
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0)
		{
			Die();
		}

		if (Input.GetKeyUp ("space") || Input.GetMouseButtonUp(0)) {
			jump++;
			rb.simulated = true;
			rb.velocity = Vector2.zero;
			rb.AddForce (force);




		}
	}

	void OnGUI()
	{
		
		GUI.color = Color.cyan;
		if (jump == 0) {
			GUILayout.Label (" Press Spacebar or Mouse to control");
		}
		GUILayout.Label (" Score: " + score.ToString ());
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Score") {
			
			score++;
			Destroy (col.gameObject);
		} else {
			Die ();
		}
	}
}
