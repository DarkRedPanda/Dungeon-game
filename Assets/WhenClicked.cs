using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WhenClicked : MonoBehaviour {

	public Button StartGame;

	void Start () {
		Button btn = StartGame.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
	}

}