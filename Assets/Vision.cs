using UnityEngine;
using System.Collections;

public class Vision : MonoBehaviour {

	Crate uncertain;
	TileFog certain;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Crate") {
			uncertain = other.gameObject.GetComponent<Crate>();
			uncertain.uncertaintyLevel = 0f;
			uncertain.UpdateState (false);

			Debug.Log ("In Trigger");

		}

		if (other.gameObject.tag == "FogTile") {
			certain = other.gameObject.GetComponent<TileFog> ();
			certain.uncertaintyLevel = 0f;
			certain.UpdateColor(false);
		
		}
		/*if (GameObject.FindGameObjectWithTag ("Enemy")) {


		}*/

	
	}
}
