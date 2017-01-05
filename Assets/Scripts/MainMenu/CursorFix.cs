using UnityEngine;
using System.Collections;

public class CursorFix : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
}
