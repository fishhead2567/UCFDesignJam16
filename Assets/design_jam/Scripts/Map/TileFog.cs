using UnityEngine;
using System.Collections;

public class TileFog : Tile, ITurnChangeGeneric {
	
	public float uncertaintyLevel = .75f;
	public GameObject RevealObject;
	public int test = 0;
	public Color dark = new Color(.25f, .25f, .25f, 1.0f);
	public Color med = new Color(.25f, .25f, .25f, 1.0f);
	public Color lightColor = new Color(0.25f, 0.25f, 0.25f, .5f);
	public Color invis = new Color(0.0f, 0.0f, 0.0f, 0.0f);
	public Color currentColor;
	public Color lastColor;

	// Use this for initialization
	void Start () {
		currentColor = dark;
		lastColor = lightColor;
		test = 0;
		uncertaintyLevel = 0.48f;
		UpdateColor (true);
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void TurnChange() {
		// increment uncertainty
		uncertaintyLevel = uncertaintyLevel + 0.1f;
		// Debug.Log ("UNCERTAINTY");
		// Debug.Log (uncertaintyLevel);
		if (uncertaintyLevel > 0.75f) {
			uncertaintyLevel = 0.75f;
		}
		UpdateColor (false);
	}

	void OnMouseExit() {
		transform.GetComponent<Renderer> ().material.color = currentColor;
	}

	void OnMouseDown() {
		PartyGameManager.instance.moveCurrentPlayer(this);
	}

	public void UpdateColor(bool force) {
		if (uncertaintyLevel >= 0.75f) {
			currentColor = dark;
		} else if (uncertaintyLevel > .5) {
			currentColor = med;
		} else if (uncertaintyLevel > .25) {
			currentColor = lightColor;
		} else {
			currentColor = invis;
		}
		if (lastColor != currentColor || force) {
			// Debug.Log ("new color");
			// Debug.Log (uncertaintyLevel);
			// Debug.Log(currentColor);
			transform.GetComponent<Renderer> ().material.color = currentColor;
		}
		lastColor = currentColor;
	}
}
