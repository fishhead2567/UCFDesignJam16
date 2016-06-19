using UnityEngine;
using System.Collections;

public class Crate : MonoBehaviour {
	public float crateState = 0f;
    public float uncertaintyLevel = 0f;
	public GameObject state1;
	public GameObject state2;
	public GameObject state3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (crateState == 0f) {
		
			state1.gameObject.SetActive (false);
			state2.gameObject.SetActive (false);
			state3.gameObject.SetActive (true);
		}

		if (crateState == 1f) {
			state1.gameObject.SetActive (true);
			state2.gameObject.SetActive (false);
			state3.gameObject.SetActive (false);
		}
		if (crateState == 2f) {
			state1.gameObject.SetActive (false);
			state2.gameObject.SetActive (true);
			state3.gameObject.SetActive (false);
		}
		 if (crateState == 3f) {
			state1.gameObject.SetActive (false);
			state2.gameObject.SetActive (false);
			state3.gameObject.SetActive (false);
		}
	
	}
}
