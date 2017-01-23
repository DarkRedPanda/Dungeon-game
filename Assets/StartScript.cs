using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {
	public int Startss;
	// Use this for initialization
	void Start () {
		Startss = 0;
	}

	// Update is called once per frame
	void Update () {
		if (Startss == 0) {
			Startss++;
			SceneManager.LoadScene (1);
		}
	}
}