using UnityEngine;
using System.Collections;

public class UserPlayer : Player {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float xAxisValue = Input.GetAxis("Horizontal") * 0.02f;
        float yAxisValue = Input.GetAxis("Vertical") * 0.02f;
		bool goUp = Input.GetKeyDown (KeyCode.Q);
		bool goDown = Input.GetKeyDown (KeyCode.E);
		float zTranslate = 0.0f;
		if (goUp) {
			zTranslate = 5.0f;
		} else if (goDown) {
			zTranslate = -5.0f;
		}
        if (Camera.current != null)
        {
			Camera.current.transform.Translate(new Vector3(xAxisValue, yAxisValue, zTranslate));
        }

    }
	
	public override void TurnUpdate ()
	{
		if (Vector3.Distance(moveDestination, transform.position) > 0.1f) {
			transform.position += (moveDestination - transform.position).normalized * moveSpeed * Time.deltaTime;
			
			if (Vector3.Distance(moveDestination, transform.position) <= 0.1f) {
				transform.position = moveDestination;
				GameManager.instance.nextTurn();
			}
		}
		
		base.TurnUpdate ();
	}
}
