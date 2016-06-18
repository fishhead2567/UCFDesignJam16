using UnityEngine;
using System.Collections;

public class TileFog : Tile, ITurnChangeGeneric {
	
	public float uncertaintyLevel;
	public GameObject RevealObject;
	public int test = 0;
	public Color currentColor;
	// Use this for initialization
	void Start () {
		test = 0;
		currentColor = Color.white;
	}
	
	// Update is called once per frame
	void Update () {

		test += 1;
		if (test % 500 == 0) {
			TurnChange ();
		}
	}

	public void TurnChange() {
		// increment uncertainty
		uncertaintyLevel += 0.1f;
		Debug.Log ("UNCERTAINTY");
		Debug.Log (uncertaintyLevel);
		if (uncertaintyLevel > 0.75f) {
			uncertaintyLevel = 0.75f;
		} else {
			currentColor = new Color (1.0f - uncertaintyLevel, 
				1.0f - uncertaintyLevel, 
				1.0f - uncertaintyLevel,
				1.0f);
			transform.GetComponent<Renderer> ().material.color = currentColor;
		}


		
	}

	void OnMouseExit() {
		transform.GetComponent<Renderer> ().material.color = currentColor;
	}
}
