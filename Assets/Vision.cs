using UnityEngine;
using System.Collections;

public class Vision : MonoBehaviour {

	Crate uncertain;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter (Collider other) {

		if (GameObject.FindGameObjectWithTag ("Crate")) {

			uncertain.uncertaintyLevel = 0f;

			Debug.Log ("In Trigger");

		}

		if (GameObject.FindGameObjectWithTag ("FogTile")) {
		
		
		}
		if (GameObject.FindGameObjectWithTag ("Enemy")) {


		}

	
	}
}
