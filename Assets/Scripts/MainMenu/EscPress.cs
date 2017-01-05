using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ExampleClass : MonoBehaviour {
	void Update() {
		if (Input.GetKeyDown("escape"))
			SceneManager.LoadScene (0);
			print("escape key was pressed");

	}
}