using UnityEngine;

public class MoveButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
		var manager = FindObjectOfType<PartyGameManager> ();
		manager.AdvanceTurn ();
    }
}
