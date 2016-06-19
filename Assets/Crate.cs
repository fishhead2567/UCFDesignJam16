using UnityEngine;
using System.Collections;

public class Crate : MonoBehaviour, ITurnChangeGeneric {
	public float crateState = 0.0f;
    public float uncertaintyLevel = 0.75f;
	public GameObject state1;
	public GameObject state2;
	public GameObject state3;
	// Use this for initialization
	void Start () {
		UpdateState (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TurnChange() {
		uncertaintyLevel = uncertaintyLevel + .1f;
		UpdateState (true);
	}

	public void UpdateState(bool force) {
		if (uncertaintyLevel >= .75) {
			crateState = 3;
		} else if (uncertaintyLevel >= .5) {
			crateState = 2;
		} else if (uncertaintyLevel >= .25) {
			crateState = 1;
		} else {
			crateState = 0;
		}

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
