using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

	// Use this for initialization
	public void Start ()
	{
		SceneManager.LoadScene ("Flappy");
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

