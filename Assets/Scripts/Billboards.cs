using UnityEngine;
using System.Collections;

public class Billboards : MonoBehaviour {

	public Transform player;

	void Start (){



	}



	void Update () {

		if(Vector3.Distance(player.position, this.transform.position) < 1000)
		{
			Vector3 direction = player.position - this.transform.position;
			direction.y = 0;

			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

		}



	}



}